using System.Net;

namespace OnlyFriends.Infrastructure
{
    public class ErrorHandling
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandling> _logger;

        public ErrorHandling(RequestDelegate next, ILogger<ErrorHandling> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Call the next middleware in the pipeline
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError(ex, "An unhandled exception occurred: {Message}", ex.Message);

                // Set the response status code and content type
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                // Create the response object
                var response = new
                {
                    StatusCode = context.Response.StatusCode,
                    Message = "An unexpected error occurred. Please try again later."
                };

                // Write the response back to the client
                await context.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
