using BLL.Services;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class OperacionesMiddleware
    {
        private readonly EmpleadosService _service;
        private readonly RequestDelegate _next;
        public OperacionesMiddleware(RequestDelegate next, EmpleadosService service)
        {
            _next = next;
            _service = service;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);

            if (context.Request.Path.Equals("/api/login", StringComparison.OrdinalIgnoreCase) &&
            context.Response.StatusCode == StatusCodes.Status200OK)
            {
                // Aquí deberías obtener el ID del empleado desde el contexto (ej., del cuerpo de la solicitud)
                string employeeId = "id_del_empleado"; // Cambia esto según tu implementación

                // Llama al método del servicio para registrar el login
                await _service.GenerarOperacion(employeeId);
            }
        }
    }
}
