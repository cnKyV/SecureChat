﻿namespace SecureChat.ChatServer.Lib.Domain;

public partial class Configuration : BaseEntity<Configuration>
{
    public Configuration()
    {
        Init(this);
    }
    public override bool CreateNew(Configuration t)
    {
        throw new NotImplementedException();
    }

    public override bool Update(Guid id, Configuration t)
    {
        throw new NotImplementedException();
    }

    public override bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}