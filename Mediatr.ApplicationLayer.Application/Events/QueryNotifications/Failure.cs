namespace Mediatr.ApplicationLayer.Application.Events.QueryNotifications
{
    public record Failure<TData>(string Message, TData Data, IEnumerable<string>? Errors = null) :
        QueryNotification<TData>(false, Data);
}