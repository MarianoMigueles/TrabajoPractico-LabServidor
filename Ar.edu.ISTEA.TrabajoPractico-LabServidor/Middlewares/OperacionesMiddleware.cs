using BLL.Services;
using BLL.Services.Interface;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class OperacionesMiddleware(RequestDelegate next, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory, ILogger<BaseMiddleware> logger) : BaseMiddleware(next, scopeFactory, logger)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            if (!(context.Request.Path.StartsWithSegments("/api/Empleado/LogInEmpleado", StringComparison.OrdinalIgnoreCase)))
            {
                var empleado = ObtenerEmpleadoEnJWT(context);

                var endPoint = context.Request.Path.Value?.Split("/");

                var endPointName = endPoint?.LastOrDefault();
                var usuario = empleado[0].ToString();
                var nombre = empleado[1].ToString();
                var sector = empleado[2].ToString();

                using var scope = _scopeFactory.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<IEmpleadosService>();
                await service.GenerarOperacion(usuario, sector, endPointName);
            }

            await _next(context);
        }
    }
}
