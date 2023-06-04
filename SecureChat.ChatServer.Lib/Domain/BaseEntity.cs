using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;
using SecureChat.ChatServer.Lib.Interface;

namespace SecureChat.ChatServer.Lib.Domain;

public abstract class BaseEntity<T> : IBaseEntity
{
    protected void Init(T t)
    {
        if (string.IsNullOrEmpty(CreatedBy))
            CreatedBy = "SYSTEM";

        if (string.IsNullOrEmpty(UpdatedBy))
            UpdatedBy = "SYSTEM";
        
        CreatedDateTime = DateTimeOffset.Now;
        UpdatedDateTime = DateTimeOffset.Now;
    }
    
    public abstract bool CreateNew(T t);
    public abstract bool Update(Guid id, T t);
    public abstract bool Delete(Guid id);
    
    public Guid Id { get; set; }
    public int FriendlyId { get; set; }
    public byte[] RowVersion { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public DateTimeOffset UpdatedDateTime { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}
