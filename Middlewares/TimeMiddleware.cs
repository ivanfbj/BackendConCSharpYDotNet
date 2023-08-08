using System;

// namespace BackendConCSharpYDotNet.Middlewares
// {
    public class TimeMiddleware
    {
        // Permite invocar el Middleware que sigue dentro del ciclo de los middleware.
        readonly RequestDelegate next;

        public TimeMiddleware(RequestDelegate nextRequest)
        {
            next = nextRequest;
        }

        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context)
        {
            await next(context); // Con esto procesa todo el JSON y al final agregar la logica que se le indica

            if (context.Request.Query.Any(p => p.Key == "time"))
            {
                await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
            }
        }
    }

    public static class TimeMiddlewareExtension
    {
        public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeMiddleware>();
        }
    }
// }
