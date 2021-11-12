FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SecurAPI/SecurAPI.csproj", "SecurAPI/"]
RUN dotnet restore "SecurAPI/SecurAPI.csproj"
COPY . .
WORKDIR "/src/SecurAPI"
RUN dotnet build "SecurAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecurAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecurAPI.dll"]
