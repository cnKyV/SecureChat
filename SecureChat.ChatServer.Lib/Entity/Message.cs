namespace SecureChat.ChatServer.Lib.Domain;

public partial class Message
{
    public string Content { get; set; }
    public Guid SessionId { get; set; }
    public User Sender { get; set; }
    public User Receiver { get; set; }
}