#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["muchik.market.security.api/muchik.market.security.api.csproj", "muchik.market.security.api/"]
RUN dotnet restore "muchik.market.security.api/muchik.market.security.api.csproj"
COPY . .
WORKDIR "/src/muchik.market.security.api"
RUN dotnet build "muchik.market.security.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "muchik.market.security.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "muchik.market.security.api.dll"]