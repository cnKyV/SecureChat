FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SecureChat.ChatServer/SecureChat.ChatServer.csproj", "SecureChat.ChatServer/"]
RUN dotnet restore "SecureChat.ChatServer/SecureChat.ChatServer.csproj"
COPY . .
WORKDIR "/src/SecureChat.ChatServer"
RUN dotnet build "SecureChat.ChatServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecureChat.ChatServer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecureChat.ChatServer.dll"]
