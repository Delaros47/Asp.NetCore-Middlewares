﻿namespace WebApplication3.Middleware
{
    public class ResponseEditingMiddleware
    {

        private RequestDelegate _requestDelegate;
        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                await context.Response.WriteAsync("Page hasnt been found");
            }

        }

    }
}
