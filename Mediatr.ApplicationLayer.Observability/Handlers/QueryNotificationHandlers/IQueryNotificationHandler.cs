using MediatR;
using Mediatr.ApplicationLayer.Application.Events.QueryNotifications;

namespace Mediatr.ApplicationLayer.Observability.Handlers.QueryNotificationHandlers
{
    public interface IQueryNotificationHandler<TNotification, TData> : INotificationHandler<TNotification>
        where TNotification : IQueryNotification<TData>;
}