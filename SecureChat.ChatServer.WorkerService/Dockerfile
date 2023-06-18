FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SecureChat.ChatServer.WorkerService/SecureChat.ChatServer.WorkerService.csproj", "SecureChat.ChatServer.WorkerService/"]
RUN dotnet restore "SecureChat.ChatServer.WorkerService/SecureChat.ChatServer.WorkerService.csproj"
COPY . .
WORKDIR "/src/SecureChat.ChatServer.WorkerService"
RUN dotnet build "SecureChat.ChatServer.WorkerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SecureChat.ChatServer.WorkerService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SecureChat.ChatServer.WorkerService.dll"]
