using Exeptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Storage;
using System.Net;

namespace Ar.edu.ISTEA.TrabajoPractico_LabServidor.Middlewares
{
    public class HandlerExeptionsMiddleware(RequestDelegate next, Microsoft.Extensions.DependencyInjection.IServiceScopeFactory scopeFactory, ILogger<BaseMiddleware> logger) : BaseMiddleware(next, scopeFactory, logger)
    {

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);

                if (context.Response.StatusCode == (int)HttpStatusCode.Forbidden)
                {
                    var policyName = context.GetEndpoint()?.Metadata
                        .GetMetadata<AuthorizeAttribute>()?.Policy ?? "desconocido";

                    throw new UnauthorizedAccessException($"Acceso no autorizado. Solo los empleados con el rol '{policyName}' pueden acceder.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Algo salio mal: {ex.Message}");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            switch (exception)
            {

                case EntityAlreadyExistsException:
                    context.Response.StatusCode = (int)HttpStatusCode.Conflict; // 409
                    break;

                case EntityDeletionException:
                case EntityNotFoundException:
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound; // 404
                    break;

                case EntityUpdateException:
                case EntityCreationException:
                case DatabaseOperationException:
                case InvalidEntityException:
                case InvalidStateException:
                case InvalidOperationException:
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest; // 400
                    break;

                case UnauthorizedAccessException:
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden; // 403
                    break;

                default:
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // 500
                    break;
            }

            var response = new
            {
                StatusCode = context.Response.StatusCode,
                Message = "Ocurrio un error mientras se procesaba su pedido.",
                Detailed = exception.Message 
            };

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}
