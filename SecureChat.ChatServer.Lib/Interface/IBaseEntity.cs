using System.ComponentModel.DataAnnotations;

namespace SecureChat.ChatServer.Lib.Interface;

public interface IBaseEntity
{
    public Guid Id { get; set; }
    public int FriendlyId { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }
    public DateTimeOffset CreatedDateTime { get; set; }
    public DateTimeOffset UpdatedDateTime { get; set; } 
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
}