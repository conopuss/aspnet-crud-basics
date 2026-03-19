using ASP_CRUD_and_git_practice.Models;

namespace ASP_CRUD_and_git_practice.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke (HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError("An unhandled error occured.");

                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var error = new ErrorResponse
                {
                    StatusCode = 500,
                    Message = "An unexpected error occured",
                    Details = ex.Message,
                };

                var json = System.Text.Json.JsonSerializer.Serialize (error);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
