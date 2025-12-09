using MediatR;

namespace Mediatr.ApplicationLayer.Application.Events.CommandNotifications
{
    public interface ICommandNotification : INotification
    {
        bool IsSuccess { get;  }
    }
}