FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble-chiseled AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/dotnet8/performance-non-root-port-8080/performance-non-root-port-8080.csproj", "src/dotnet8/performance-non-root-port-8080/"]
RUN dotnet restore "src/dotnet8/performance-non-root-port-8080/performance-non-root-port-8080.csproj"
COPY . .
WORKDIR "/src/src/dotnet8/performance-non-root-port-8080"
RUN dotnet build "performance-non-root-port-8080.csproj" -c $BUILD_CONFIGURATION -o /app/build /p:DebugType=None /p:DebugSymbols=false

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "performance-non-root-port-8080.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "performance-non-root-port-8080.dll"]
