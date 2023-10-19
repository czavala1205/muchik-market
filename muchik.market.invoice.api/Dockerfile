#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["muchik.market.invoice.api/muchik.market.invoice.api.csproj", "muchik.market.invoice.api/"]
COPY ["muchik.market.infraestructure.bus/muchik.market.infraestructure.bus.csproj", "muchik.market.infraestructure.bus/"]
COPY ["muchik.market.domain/muchik.market.domain.csproj", "muchik.market.domain/"]
COPY ["muchik.market.infraestructure.ioc/muchik.market.infrastructure.ioc.csproj", "muchik.market.infraestructure.ioc/"]
COPY ["muchik.market.invoice.application/muchik.market.invoice.application.csproj", "muchik.market.invoice.application/"]
COPY ["muchik.market.invoice.domain/muchik.market.invoice.domain.csproj", "muchik.market.invoice.domain/"]
COPY ["muchik.market.invoice.infraestructure/muchik.market.invoice.infrastructure.csproj", "muchik.market.invoice.infraestructure/"]
RUN dotnet restore "muchik.market.invoice.api/muchik.market.invoice.api.csproj"
COPY . .
WORKDIR "/src/muchik.market.invoice.api"
RUN dotnet build "muchik.market.invoice.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "muchik.market.invoice.api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "muchik.market.invoice.api.dll"]