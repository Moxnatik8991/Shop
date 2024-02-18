using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Shop.Models;
using System;
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

            //switch (exception)
            //{
            //    case KeyNotFoundException
            //            or NoSuchUserException
            //            or FileNotFoundException:
            //        code = HttpStatusCode.NotFound;
            //        break;
            //    case EntityAlreadyExists:
            //        code = HttpStatusCode.Conflict;
            //        break;
            //    case UnauthorizedAccessException
            //            or ExpiredPasswordException
            //            or UserBlockedException:
            //        code = HttpStatusCode.Unauthorized;
            //        break;
            //    case CreateUserException
            //            or ResetPasswordException
            //            or ArgumentException
            //            or InvalidOperationException:
            //        code = HttpStatusCode.BadRequest;
            //        break;
            //    default:
            //        code = HttpStatusCode.InternalServerError;
            //        break;
            //}

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.OK;

            var response = new BaseResponseModel<string> ();
            response.SetFailResponse(ex.Message); 

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
