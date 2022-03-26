namespace WebApplication3.Middleware
{
    public class RequestEditingMiddleware
    {

        private RequestDelegate _requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/Home")
            {
                await context.Response.WriteAsync("Welcome Hamdi");
            }
            else
            {
                await _requestDelegate.Invoke(context);
            }

        }

    }
}
