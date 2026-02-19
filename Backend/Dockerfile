FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Peliculas.API/Peliculas.API.csproj", "Peliculas.API/"]
COPY ["Peliculas.Application/Peliculas.Application.csproj", "Peliculas.Application/"]
COPY ["Peliculas.Domain/Peliculas.Domain.csproj", "Peliculas.Domain/"]
COPY ["Peliculas.Infraestructure/Peliculas.Infraestructure.csproj", "Peliculas.Infraestructure/"]

RUN dotnet restore "Peliculas.API/Peliculas.API.csproj"

COPY . .
WORKDIR "/src/Peliculas.API"
RUN dotnet build "Peliculas.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Peliculas.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Peliculas.API.dll"]
