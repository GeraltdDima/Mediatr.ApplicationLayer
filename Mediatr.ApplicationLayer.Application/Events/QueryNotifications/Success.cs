namespace Mediatr.ApplicationLayer.Application.Events.QueryNotifications
{
    public record Success<TData>(string Message, TData Data) : QueryNotification<TData>(true, Data);
}