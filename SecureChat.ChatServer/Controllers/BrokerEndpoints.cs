namespace SecureChat.ChatServer.Controllers;

public static class BrokerEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapPost("/send", () => "Hello World");
        app.MapGet("/receive", () => "Hello World");
    }
}