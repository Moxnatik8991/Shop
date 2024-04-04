using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using System;
using System.Net;

namespace Shop.BackApp.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private ILogger<ExceptionHandlingMiddleware> _logger;
        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

                if (context.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedException();
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, null);
                await HandleExceptionAsync(context, exception);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var message = ex.Message;
            var statusCode = (int)HttpStatusCode.OK;

            switch (ex)
            {
                case UnauthorizedException:
                    statusCode = (int)HttpStatusCode.Unauthorized;
                    message = "Unauthorized";
                    break;

                case KeyNotFoundException
                        or NotFoundException
                        or FileNotFoundException:
                    statusCode = (int)HttpStatusCode.NotFound;
                    break;

                case UnsupportedFileException:
                    statusCode = (int)HttpStatusCode.UnsupportedMediaType;
                    break;

                case CustomException:
                    statusCode = 555;
                    break;
                default:

                    

                    statusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = new BaseResponseModel<string>();
            response.SetFailResponse(message);

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
