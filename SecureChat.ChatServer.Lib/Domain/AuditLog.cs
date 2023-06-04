namespace SecureChat.ChatServer.Lib.Domain;

public partial class AuditLog : BaseEntity<AuditLog>
{
    public AuditLog()
    {
        Init(this);
    }
    public override bool CreateNew(AuditLog t)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Guid id, AuditLog t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}