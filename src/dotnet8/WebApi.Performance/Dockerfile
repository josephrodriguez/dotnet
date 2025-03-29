FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble-chiseled AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/dotnet8/WebApi.Performance/WebApi.Performance.csproj", "src/dotnet8/WebApi.Performance/"]
RUN dotnet restore "src/dotnet8/WebApi.Performance/WebApi.Performance.csproj"
COPY . .
WORKDIR "/src/src/dotnet8/WebApi.Performance"
RUN dotnet build "WebApi.Performance.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WebApi.Performance.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false /p:DebugType=None /p:DebugSymbols=false

FROM base AS final
ENV ASPNETCORE_HTTP_PORTS=8080
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApi.Performance.dll"]