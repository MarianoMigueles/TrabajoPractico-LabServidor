using BLL.DTO.Empleados;
using BLL.Services;
using BLL.Services.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class BaseMiddleware
    {
        protected readonly Microsoft.Extensions.DependencyInjection.IServiceScopeFactory _scopeFactory;
        protected readonly RequestDelegate _next;
        protected readonly ILogger<BaseMiddleware> _logger;

        public BaseMiddleware(RequestDelegate next, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory, ILogger<BaseMiddleware> logger)
        {
            _next = next;
            _scopeFactory = scopeFactory;
            _logger = logger;
        }

        private static bool ValidarToken(HttpContext context, out JwtSecurityToken jwtToken)
        {
            jwtToken = null;
            var authHeader = context.Request.Headers["Authorization"].ToString();

            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                var token = authHeader.Substring("Bearer ".Length).Trim();
                var tokenHandler = new JwtSecurityTokenHandler();

                try
                {
                    jwtToken = tokenHandler.ReadJwtToken(token);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException($"Error al validar el token: {ex.Message}");
                }
            }
            else
            {
                throw new UnauthorizedAccessException("Error, no se encontró ningún token de autorización");
            }
        }

        protected async Task<string> ObtenerUsuarioEmpleadoEnBody(HttpContext context)
        {
            context.Request.EnableBuffering();

            using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, true))
            {
                var body = await reader.ReadToEndAsync();
                context.Request.Body.Position = 0;

                var logInRequest = JsonConvert.DeserializeObject<EmpleadoDTO>(body);
                var usuario = logInRequest?.Usuario;

                return usuario;
            }

        }

        protected string[] ObtenerEmpleadoEnJWT(HttpContext context)
        {
            if (ValidarToken(context, out var jwtToken))
            {
                return ObtenerEmpleadoEnJWT(jwtToken);
            }
            return null;
        }

        private static string[] ObtenerEmpleadoEnJWT(JwtSecurityToken jwtToken)
        {
            var usuarioClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "Usuario");
            var nombreClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "Nombre");
            var sectorClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == "Sector");

            var usuario = usuarioClaim?.Value;
            var nombre = nombreClaim?.Value;
            var sector = sectorClaim?.Value;

            if (usuario != null && nombre != null && sector != null)
            {
                return [usuario, nombre, sector];
            }
            else
            {
                return null;
            }
        }
    }
}
