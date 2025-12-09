namespace Mediatr.ApplicationLayer.Application.Events.CommandNotifications
{
    public record Failure(string Message, IEnumerable<string>? Errors = null) : CommandNotification(false);
}