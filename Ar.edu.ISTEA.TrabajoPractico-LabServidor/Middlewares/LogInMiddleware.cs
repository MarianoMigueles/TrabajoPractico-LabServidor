using BLL.DTO.Empleados;
using BLL.Services;
using BLL.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Text;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class LogInMiddleware(RequestDelegate next, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory, ILogger<BaseMiddleware> logger) : BaseMiddleware(next, scopeFactory, logger)
    {

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api/Empleado/LogInEmpleado", StringComparison.OrdinalIgnoreCase))
            {
                if (context.Request.Method == HttpMethods.Post)
                {
                    var usuario = await ObtenerUsuarioEmpleadoEnBody(context);                   

                    if(usuario != null)
                    {
                        using var scope = _scopeFactory.CreateScope();
                        var service = scope.ServiceProvider.GetRequiredService<IEmpleadosService>();
                        await service.GenerarInicioSecion(usuario);
                    }
                }
                
            }

            await _next(context);
        }
    }

}
