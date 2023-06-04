namespace SecureChat.ChatServer.Lib.Domain;

public partial class Configuration
{
    public Guid Id { get; set; }
    public int FriendlyId { get; set; }
    public byte[] RowVersion { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public DateTimeOffset UpdatedDateTime { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}