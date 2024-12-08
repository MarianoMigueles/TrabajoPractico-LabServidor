using BLL.Services.Interface;
using DAL.Repositorios.Interfaces;
using Entities.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Filters
{
    public class FiltroAutorizacionEmpleado : IAsyncActionFilter
    {
        protected readonly Microsoft.Extensions.DependencyInjection.IServiceScopeFactory _scopeFactory;

        public FiltroAutorizacionEmpleado(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var user = context.HttpContext.User;

            var sectorClaim = user.Claims.FirstOrDefault(c => c.Type == "Sector")?.Value;
            if (string.IsNullOrEmpty(sectorClaim) || !Enum.TryParse<ESectores>(sectorClaim, ignoreCase: true, out var sectorUsuario))
            {
                context.Result = new ForbidResult(); 
                return;
            }

            var routeData = context.RouteData.Values;
            if (!routeData.TryGetValue("idPedido", out var pedidoIdValue) || !int.TryParse(pedidoIdValue.ToString(), out var pedidoId))
            {
                context.Result = new BadRequestObjectResult("El ID del pedido no es válido.");
                return;
            }

            using var scope = _scopeFactory.CreateScope();
            var pedidoService = scope.ServiceProvider.GetRequiredService<IPedidosRepository>();
            var productoService = scope.ServiceProvider.GetRequiredService<IProductosRepository>();

            var pedido = await pedidoService.GetById(pedidoId);
            var producto = await productoService.GetById(pedido.IdProducto);

            var puedeCambiarEstado = PuedeCambiarEstado(sectorUsuario, producto.Sector);
            if (!puedeCambiarEstado)
            {
                throw new UnauthorizedAccessException("No se puede cambiar el estado del producto porque no pertenece al sector del usuario.");
            }

            await next();
        }

        private bool PuedeCambiarEstado(ESectores sectorUsuario, ESectores sectorProducto)
        {
            return sectorUsuario == sectorProducto;
        }
    }
}
