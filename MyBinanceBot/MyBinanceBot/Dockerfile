FROM mcr.microsoft.com/dotnet/core/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["MyBinanceBot/MyBinanceBot.csproj", "MyBinanceBot/"]
RUN dotnet restore "MyBinanceBot/MyBinanceBot.csproj"
COPY . .
WORKDIR "/src/MyBinanceBot"
RUN dotnet build "MyBinanceBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyBinanceBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyBinanceBot.dll"]
