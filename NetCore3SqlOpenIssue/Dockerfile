#FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0.0-preview9-buster-slim AS base
WORKDIR /app

#FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview9-buster AS build
WORKDIR /src
COPY ["NetCore3SqlOpenIssue/NetCore3SqlOpenIssue.csproj", "NetCore3SqlOpenIssue/"]
RUN dotnet restore "NetCore3SqlOpenIssue/NetCore3SqlOpenIssue.csproj"
COPY . .
WORKDIR "/src/NetCore3SqlOpenIssue"
RUN dotnet build "NetCore3SqlOpenIssue.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NetCore3SqlOpenIssue.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NetCore3SqlOpenIssue.dll"]