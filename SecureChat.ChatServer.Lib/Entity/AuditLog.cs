using SecureChat.ChatServer.Lib.Enums;

namespace SecureChat.ChatServer.Lib.Domain;

public partial class AuditLog
{
    public Guid SessionId { get; set; }
    public User User { get; set; }
    public string AuditMessage { get; set; }
    public AuditActionMessage AuditActionMessage { get; set; }
}