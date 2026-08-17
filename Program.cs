var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:8080", "http://*:5000"); // Standard container ports
var app = builder.Build();

app.MapGet("/", () => "Hello from GitHub CI/CD Pipeline! App version: 1.0.0");

app.Run();
