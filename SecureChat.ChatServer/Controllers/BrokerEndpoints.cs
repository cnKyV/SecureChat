
using Microsoft.AspNetCore.Mvc;

namespace SecureChat.ChatServer.Controllers;

public static class BrokerEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/create-session", ([FromBody] string publicKey) => "Hello World");
    }
}