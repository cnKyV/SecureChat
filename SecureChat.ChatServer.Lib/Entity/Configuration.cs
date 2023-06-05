namespace SecureChat.ChatServer.Lib.Domain;

public partial class Configuration
{
    public string Key { get; set; }
    public string Value { get; set; }
    public User User { get; set; }
}