using MediatR;
using Mediatr.ApplicationLayer.Application.Commands;
using Mediatr.ApplicationLayer.Application.Events.CommandNotifications;

namespace Mediatr.ApplicationLayer.Infrastructure.Handlers.CommandHandlers
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, ICommandNotification>
        where TCommand : ICommand;
}