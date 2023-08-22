FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TestClient/TestClient.csproj", "TestClient/"]
RUN dotnet restore "TestClient/TestClient.csproj"
COPY . .
WORKDIR "/src/TestClient"
RUN dotnet build "TestClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestClient.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestClient.dll"]
