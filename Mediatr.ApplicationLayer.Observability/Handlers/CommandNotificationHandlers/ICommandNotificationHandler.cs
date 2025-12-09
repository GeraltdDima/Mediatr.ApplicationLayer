using MediatR;
using Mediatr.ApplicationLayer.Application.Events.CommandNotifications;

namespace Mediatr.ApplicationLayer.Observability.Handlers.CommandNotificationHandlers
{
    public interface ICommandNotificationHandler<TNotification> : INotificationHandler<TNotification>
        where TNotification : ICommandNotification;
}