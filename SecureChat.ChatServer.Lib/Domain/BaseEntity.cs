using System.ComponentModel.DataAnnotations;
using SecureChat.ChatServer.Lib.Interface;

namespace SecureChat.ChatServer.Lib.Domain;

public abstract class BaseEntity<T>
{
    public abstract bool CreateNew(T t);
    public abstract bool Update(Guid id, T t);
    public abstract bool Delete(Guid id);
}
