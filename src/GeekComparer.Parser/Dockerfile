FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/GeekComparer.Parser/GeekComparer.Parser.csproj", "src/GeekComparer.Parser/"]
RUN dotnet restore "src/GeekComparer.Parser/GeekComparer.Parser.csproj"
COPY . .
WORKDIR "/src/src/GeekComparer.Parser"
RUN dotnet build "GeekComparer.Parser.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GeekComparer.Parser.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeekComparer.Parser.dll"]
