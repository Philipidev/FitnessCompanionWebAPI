using FitnessCompanionWebAPI.Aplicacao.Exceptions;
using FitnessCompanionWebAPI.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;

namespace FitnessCompanionWebAPI.Middleware
{
    public static class ExceptionHandlerMiddleware
    {
        public static Action<IApplicationBuilder> ExceptionHandler()
        {
            return app =>
            {
                app.Run(async context =>
                {
                    Exception exception = context.Features.Get<IExceptionHandlerFeature>()?.Error;
                    if (exception != null)
                        await context.WriteJsonResponseAsync(exception);
                });
            };
        }

        public static async Task WriteJsonResponseAsync(this HttpContext context, Exception exception)
        {
            ErrorResponse errorResponse = ExceptionSwitcher(exception);
            context.Response.StatusCode = errorResponse.StatusCode;
            context.Response.ContentType = MediaTypeNames.Application.Json;
            byte[] responseBody = JsonSerializer.SerializeToUtf8Bytes(errorResponse, typeof(ErrorResponse));
            await context.Response.Body.WriteAsync(responseBody, 0, responseBody.Length);
        }


        public static ErrorResponse ExceptionSwitcher(Exception exception)
        {
            if (exception is SenhaInvalidaException ex)
            {
                return new ErrorResponse(ex.Message, StatusCodes.Status401Unauthorized);
            }

            return new ErrorResponse(exception);
        }
    }
}
