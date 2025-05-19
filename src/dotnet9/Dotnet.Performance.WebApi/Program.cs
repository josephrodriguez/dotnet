using Dotnet.Performance.WebApi.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddJsonServices();
builder.Services.AddInfrastructureServices();

var app = builder.Build();

app.MapPerformanceEndpoints();
app.MapHealthEndpoint();

app.Run();