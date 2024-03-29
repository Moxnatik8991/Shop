using Newtonsoft.Json;
using Shop.BackApp.Middleware.Exceptions;
using Shop.BackApp.Models;
using System.Net;

namespace Shop.BackApp.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
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
                    message = "Something went wrong";
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
