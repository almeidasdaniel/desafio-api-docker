#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Stefanini.API/Stefanini.API.csproj", "Stefanini.API/"]
COPY ["Stefanini.Application.DTO/Stefanini.Application.DTO.csproj", "Stefanini.Application.DTO/"]
COPY ["Stefanini.Application/Stefanini.Application.csproj", "Stefanini.Application/"]
COPY ["Stefanini.Domain.Core/Stefanini.Domain.Core.csproj", "Stefanini.Domain.Core/"]
COPY ["Stefanini.Domain/Stefanini.Domain.csproj", "Stefanini.Domain/"]
COPY ["Stefanini.Infra.CrossCutting.Adapter/Stefanini.Infra.CrossCutting.Adapter.csproj", "Stefanini.Infra.CrossCutting.Adapter/"]
COPY ["Stefanini.Infra.CrossCutting.IOC/Stefanini.Infra.CrossCutting.IOC.csproj", "Stefanini.Infra.CrossCutting.IOC/"]
COPY ["Stefanini.Domain.Services/Stefanini.Domain.Services.csproj", "Stefanini.Domain.Services/"]
COPY ["Stefanini.Infra.Repository/Stefanini.Infra.Repository.csproj", "Stefanini.Infra.Repository/"]
COPY ["Stefanini.Infra.Data/Stefanini.Infra.Data.csproj", "Stefanini.Infra.Data/"]
RUN dotnet restore "Stefanini.API/Stefanini.API.csproj"
COPY . .
WORKDIR "/src/Stefanini.API"
RUN dotnet build "Stefanini.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Stefanini.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Stefanini.API.dll"]