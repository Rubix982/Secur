FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SecurWebApp/SecurWebApp.csproj", "SecurWebApp/"]
RUN dotnet restore "SecurWebApp/SecurWebApp.csproj"
COPY . .
WORKDIR "/src/SecurWebApp"
RUN dotnet build "SecurWebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecurWebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecurWebApp.dll"]
