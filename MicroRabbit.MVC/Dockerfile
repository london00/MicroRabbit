#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2.8-bionic AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2.8-bionic AS build
WORKDIR /src
COPY ["MicroRabbit.MVC/MicroRabbit.MVC.csproj", "MicroRabbit.MVC/"]
RUN dotnet restore "MicroRabbit.MVC/MicroRabbit.MVC.csproj"
COPY . .
WORKDIR "/src/MicroRabbit.MVC"
RUN dotnet build "MicroRabbit.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroRabbit.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroRabbit.MVC.dll"]