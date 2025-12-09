using Mediatr.ApplicationLayer.Application.Events.CommandNotifications;
using Mediatr.ApplicationLayer.Observability.Handlers.MediatrNotificationHandler;

namespace Mediatr.ApplicationLayer.Observability.Handlers.CommandNotificationHandlers
{
    public abstract class CommandNotificationHandler<TNotification> :
        MediatrNotificationHandler<TNotification>,
        ICommandNotificationHandler<TNotification>
        where TNotification : ICommandNotification
    {
        public CommandNotificationHandler(EventHandler handled) : base(handled) { }
    }
}