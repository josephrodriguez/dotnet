using System.Text.Json.Serialization;
using Dotnet.Performance.Core.Models;

namespace Dotnet.Performance.WebApi;

[JsonSerializable(typeof(Movie[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}