using MediatR;
using Mediatr.ApplicationLayer.Application.Events.QueryNotifications;
using Mediatr.ApplicationLayer.Application.Queries;

namespace Mediatr.ApplicationLayer.Infrastructure.Handlers.QueryHandlers
{
    public interface IQueryHandler<TQuery, TData> : IRequestHandler<TQuery, IQueryNotification<TData>>
        where TQuery : IQuery<TData>;
}