namespace SecureChat.ChatServer.Lib.Domain;

public partial class Message : BaseEntity<Message>
{
    public Message()
    {
        Init(this);
    }
    public override bool CreateNew(Message t)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Guid id, Message t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}