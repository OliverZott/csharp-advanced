FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Events_Example_1/Events_Example_1.csproj", "Events_Example_1/"]
RUN dotnet restore "Events_Example_1/Events_Example_1.csproj"
COPY . .
WORKDIR "/src/Events_Example_1"
RUN dotnet build "Events_Example_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Events_Example_1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Events_Example_1.dll"]
