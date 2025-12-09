namespace Mediatr.ApplicationLayer.Application.Events.CommandNotifications
{
    public record Success(string Message) : CommandNotification(true);
}