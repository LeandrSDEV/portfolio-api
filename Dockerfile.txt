# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj primeiro
COPY Portfolio.Api/Portfolio.Api.csproj Portfolio.Api/

# Restaura dependências
RUN dotnet restore Portfolio.Api/Portfolio.Api.csproj

# Copia o restante do código
COPY . .

# Publica
RUN dotnet publish Portfolio.Api/Portfolio.Api.csproj -c Release -o /app/publish

# Final
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Portfolio.Api.dll"]
