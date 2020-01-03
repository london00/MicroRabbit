#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MicroRabbit.Transfer.Api/MicroRabbit.Transfer.Api.csproj", "MicroRabbit.Transfer.Api/"]
COPY ["MicroRabbit.Infra.IoC/MicroRabbit.Infra.IoC.csproj", "MicroRabbit.Infra.IoC/"]
COPY ["MicroRabbit.Transfer.Domain/MicroRabbit.Transfer.Domain.csproj", "MicroRabbit.Transfer.Domain/"]
COPY ["MicroRabbit.Doman.Core/MicroRabbit.Doman.Core.csproj", "MicroRabbit.Doman.Core/"]
COPY ["MicroRabbit.Banking.Data/MicroRabbit.Banking.Data.csproj", "MicroRabbit.Banking.Data/"]
COPY ["MicroRabbit.Banking.Domain/MicroRabbit.Banking.Domain.csproj", "MicroRabbit.Banking.Domain/"]
COPY ["MicroRabbit.Banking.Application/MicroRabbit.Banking.Application.csproj", "MicroRabbit.Banking.Application/"]
COPY ["MicroRabbit.Transfer.Application/MicroRabbit.Transfer.Application.csproj", "MicroRabbit.Transfer.Application/"]
COPY ["MicroRabbit.Transfer.Data/MicroRabbit.Transfer.Data.csproj", "MicroRabbit.Transfer.Data/"]
COPY ["MicroRabbit.Infra.Bus/MicroRabbit.Infra.Bus.csproj", "MicroRabbit.Infra.Bus/"]
RUN dotnet restore "MicroRabbit.Transfer.Api/MicroRabbit.Transfer.Api.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.Transfer.Api"
RUN dotnet build "MicroRabbit.Transfer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.Transfer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.Transfer.Api.dll"]