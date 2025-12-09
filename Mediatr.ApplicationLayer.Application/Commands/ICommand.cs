using MediatR;
using Mediatr.ApplicationLayer.Application.Events.CommandNotifications;

namespace Mediatr.ApplicationLayer.Application.Commands
{
    public interface ICommand : IRequest<ICommandNotification>;
}