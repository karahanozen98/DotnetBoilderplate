using DotnetBoilerplate.Core.Api;
using DotnetBoilerplate.Core.Exceptions;
using DotnetBoilerplate.Core.Validation;

namespace DotnetBoilerplate.Api.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await this._next(context);
            }
            catch (ValidationException exception)
            {
                var response = new ApiResponse<IEnumerable<ValidationError>>(exception.ValidationErrors);
                response.IsSuccess = false;
                response.Message = exception.Message;
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(response);
            }
            catch (Exception exception)
            {
                var response = new ApiResponse<string>(exception.ToString());
                response.Message = "An unknown exception of type occured";
                response.IsSuccess = false;
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
