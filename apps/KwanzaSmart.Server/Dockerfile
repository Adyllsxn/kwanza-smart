# Base image (runtime)
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

# Build image (SDK)
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy csproj (caminho corrigido)
COPY ["apps/KwanzaSmart.Server/KwanzaSmart.Server.csproj", "apps/KwanzaSmart.Server/"]
RUN dotnet restore "apps/KwanzaSmart.Server/KwanzaSmart.Server.csproj"

# Copy everything else
COPY . .

# Build
RUN dotnet build "apps/KwanzaSmart.Server/KwanzaSmart.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "apps/KwanzaSmart.Server/KwanzaSmart.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KwanzaSmart.Server.dll"]