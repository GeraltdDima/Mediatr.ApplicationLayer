namespace Mediatr.ApplicationLayer.Application.Events.CommandNotifications
{
    public abstract record CommandNotification(bool IsSuccess) : ICommandNotification;
}