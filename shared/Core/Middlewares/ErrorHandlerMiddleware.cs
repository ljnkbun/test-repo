using System.Net;
using System.Text.Json;
using Core.Exceptions;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Error = Core.Models.Error;

namespace Core.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new BaseResponse<string>() { Success = false, Error = [new Error() { Message = error?.Message! }], Result = error?.InnerException?.Message! };

                if (!response.HasStarted)
                {
                    switch (error)
                    {
                        case ApiException:
                            // custom application error
                            response.StatusCode = (int)HttpStatusCode.BadRequest;
                            break;
                        case ValidationException e:
                            // custom application error
                            response.StatusCode = (int)HttpStatusCode.BadRequest;
                            List<Error> errors = new();
                            e.Errors.ForEach(x => errors.Add(new Error() { Message = x }));
                            responseModel.Error = errors;
                            break;
                        case KeyNotFoundException:
                            // not found error
                            response.StatusCode = (int)HttpStatusCode.NotFound;
                            break;
                        default:
                            // unhandled error
                            response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            break;
                    }
                }
                // Get the options
                var jsonOptions = context.RequestServices.GetService<IOptions<JsonOptions>>();

                var result = JsonSerializer.Serialize(responseModel, jsonOptions?.Value.SerializerOptions);
                await response.WriteAsync(result);
            }
        }
    }
}
