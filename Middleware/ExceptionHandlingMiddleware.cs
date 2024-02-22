using Newtonsoft.Json;
using Shop.Middleware.Exceptions;
using Shop.Models;
using System.Net;

namespace Shop.Middleware
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
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var message = ex.Message;

            switch (ex)
            {
                case KeyNotFoundException
                        or NotFoundException<string>
                        or FileNotFoundException:
                    break;
                default:
                    message = "Something went wrong";
                    break;
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.OK;

            var response = new BaseResponseModel<string> ();
            response.SetFailResponse(message); 

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
