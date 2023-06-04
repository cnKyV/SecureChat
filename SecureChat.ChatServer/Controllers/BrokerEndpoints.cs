namespace SecureChat.ChatServer.Controllers;

public static class BrokerEndpoints
{
    public static void Map(WebApplication app)
    {
        app.MapGet("/broker", () => "Hello World");
    }
}