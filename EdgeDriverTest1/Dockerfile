#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:2.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:2.1 AS build
WORKDIR /src
COPY ["EdgeDriverTest1/EdgeDriverTest1.csproj", "EdgeDriverTest1/"]
RUN dotnet restore "EdgeDriverTest1/EdgeDriverTest1.csproj"
COPY . .
WORKDIR "/src/EdgeDriverTest1"
RUN dotnet build "EdgeDriverTest1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EdgeDriverTest1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EdgeDriverTest1.dll"]