using Mediatr.ApplicationLayer.Application.Events.QueryNotifications;
using Mediatr.ApplicationLayer.Observability.Handlers.MediatrNotificationHandler;

namespace Mediatr.ApplicationLayer.Observability.Handlers.QueryNotificationHandlers
{
    public abstract class QueryNotificationHandler<TNotification, TData> :
        MediatrNotificationHandler<TNotification>,
        IQueryNotificationHandler<TNotification, TData>
        where TNotification : IQueryNotification<TData>
    {
        public QueryNotificationHandler(EventHandler handled) : base(handled) { }
    }
}