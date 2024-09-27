using BLL.Services;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class LogInMiddleware
    {
        private readonly EmpleadosService _empleadosService;
        private readonly RequestDelegate _next;

        public LogInMiddleware(ILogger<LogInMiddleware> logger, RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.Equals("/api/login", StringComparison.OrdinalIgnoreCase) &&
            context.Response.StatusCode == StatusCodes.Status200OK)
            {
                
            }
        }
    }
}
