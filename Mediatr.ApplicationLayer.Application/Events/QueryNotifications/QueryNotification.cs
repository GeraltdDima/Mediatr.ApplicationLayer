namespace Mediatr.ApplicationLayer.Application.Events.QueryNotifications
{
    public abstract record QueryNotification<TData>(bool IsSuccess, TData Data) : IQueryNotification<TData>;
}