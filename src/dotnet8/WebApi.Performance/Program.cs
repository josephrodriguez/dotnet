using Prometheus;
using WebApi.Performance.Extensions;
using WebApi.Performance.Services;
using WebApi.Performance.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvcCore().AddApiExplorer();
builder.Services.AddControllers();
builder.Services.AddHealthChecks();

builder.Services.AddJsonFileMoviesRepository();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpMetrics(); 

app.MapControllers();
app.MapMetrics();
app.MapHealthz();

app.Run();