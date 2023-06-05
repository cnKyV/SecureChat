using System.ComponentModel;

namespace SecureChat.ChatServer.Lib.Enums;

public enum AuditActionMessage
{
    [Description("User Logged-in")]
    LogIn,
    [Description("User Logged-out")]
    LogOut,
    [Description("User Connected")]
    Connected,
    [Description("User Disconnected")]
    Disconnected,
    [Description("Fixtation Succesful")]
    FixtationSucces,
    [Description("Fixtation Failed")]
    FixtationFailed,
    [Description("Session Connected")]
    SessionConnect,
    [Description("Session Dropped")]
    SessionDrop
}