#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Smb.Server.Host/Smb.Server.Host.csproj", "Smb.Server.Host/"]
RUN dotnet restore "Smb.Server.Host/Smb.Server.Host.csproj"
COPY . .
WORKDIR "/src/Smb.Server.Host"
RUN dotnet build "Smb.Server.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Smb.Server.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Smb.Server.Host.dll"]