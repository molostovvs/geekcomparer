FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src

EXPOSE 80
EXPOSE 443

COPY src/ .

RUN dotnet restore GeekComparer.Web/GeekComparer.Web.csproj

RUN dotnet publish GeekComparer.Web/GeekComparer.Web.csproj -c Release /p:UseAppHost=false --self-contained false --no-restore -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine

WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "GeekComparer.Web.dll"]
