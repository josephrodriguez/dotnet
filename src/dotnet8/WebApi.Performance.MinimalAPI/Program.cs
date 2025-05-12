using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Performance.Core;
using WebApi.Performance.Infrastructure;
using WebApi.Performance.MinimalAPI.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

builder.Services.AddSingleton<IMoviesRepository>(_ => MoviesRepositoryFactory.FromJsonFile("/data.movies.json"));

var app = builder.Build();

app.MapPerformanceApiEndpoints();

app.Run();

[JsonSerializable(typeof(Movie[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}