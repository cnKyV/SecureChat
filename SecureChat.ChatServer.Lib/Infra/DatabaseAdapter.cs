using SecureChat.ChatServer.Lib.Domain;
using SecureChat.ChatServer.Lib.Interface;

namespace SecureChat.ChatServer.Lib.Infra;

public class DatabaseAdapter : IDatabaseAdapter
{
    private User _loggedInUser = new();
    private HashSet<AuditLog> _auditLogs = new();
    
}