using System.Net;

namespace CQRSWithInterface.API.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
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
            
            await HandleException(context.Response, ex);
        }
    }

    private static async Task HandleException(HttpResponse response, Exception ex)
    {
        response.ContentType = "application/json";
        var statusCode = (int)HttpStatusCode.InternalServerError;
        response.StatusCode = statusCode;

        var errorDetails = new ErrorDetails(statusCode, ex.Message);

        await response.WriteAsJsonAsync(errorDetails);
    }
}
