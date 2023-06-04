namespace SecureChat.ChatServer.Lib.Domain;

public partial class User : BaseEntity<User>
{
    public User()
    {
        Init(this);
    }
    public override bool CreateNew(User t)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Guid id, User t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}