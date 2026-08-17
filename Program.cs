var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from GitHub CI/CD Pipeline! App version: 1.0.0");

app.Run();
