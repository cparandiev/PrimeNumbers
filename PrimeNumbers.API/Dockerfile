#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["PrimeNumbers.API/PrimeNumbers.API.csproj", "PrimeNumbers.API/"]
COPY ["PrimeNumbers.Toolbox/PrimeNumbers.Toolbox.csproj", "PrimeNumbers.Toolbox/"]
COPY ["PrimeNumbers.Application/PrimeNumbers.Application.csproj", "PrimeNumbers.Application/"]
RUN dotnet restore "PrimeNumbers.API/PrimeNumbers.API.csproj"
COPY . .
WORKDIR "/src/PrimeNumbers.API"
RUN dotnet build "PrimeNumbers.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrimeNumbers.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrimeNumbers.API.dll"]