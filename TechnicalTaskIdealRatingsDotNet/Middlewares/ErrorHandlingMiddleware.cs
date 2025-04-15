using System.Net;
using System.Text.Json;

namespace TechnicalTaskIdealRatingsDotNet.Middlewares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;
    
    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var response = new { message = "Something went wrong.", error = exception.Message };
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var result = JsonSerializer.Serialize(response);
        return context.Response.WriteAsync(result);
    }
    
}