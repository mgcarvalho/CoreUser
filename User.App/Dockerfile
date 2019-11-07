FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["User.App/User.App.csproj", "User.App/"]
RUN dotnet restore "User.App/User.App.csproj"
COPY . .
WORKDIR "/src/User.App"
RUN dotnet build "User.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "User.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "User.App.dll"]