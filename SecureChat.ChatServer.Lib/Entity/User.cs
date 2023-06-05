namespace SecureChat.ChatServer.Lib.Domain;

public partial class User
{
    public char[] Username { get; set; }
    public char[] Password { get; set; }
    public string Email { get; set; }
    public string Nickname { get; set; }
    public ICollection<User> FriendList { get; set; }
    public ICollection<Message> History { get; set; }
    public ICollection<Configuration> Configurations { get; set; }
}