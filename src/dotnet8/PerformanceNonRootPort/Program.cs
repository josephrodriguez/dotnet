using PerformanceNonRootPort.Services;
using PerformanceNonRootPort.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection(); // Let's disable SSL redirection middleware

app.UseRouting();
app.MapControllers();

app.Run();