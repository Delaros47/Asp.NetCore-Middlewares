using WebApplication3.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseMiddleware<RequestEditingMiddleware>();
app.UseMiddleware<ResponseEditingMiddleware>();
app.Run();
