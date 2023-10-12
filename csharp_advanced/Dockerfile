FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["csharp_advanced/csharp_advanced.csproj", "csharp_advanced/"]
RUN dotnet restore "csharp_advanced/csharp_advanced.csproj"
COPY . .
WORKDIR "/src/csharp_advanced"
RUN dotnet build "csharp_advanced.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "csharp_advanced.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "csharp_advanced.dll"]
