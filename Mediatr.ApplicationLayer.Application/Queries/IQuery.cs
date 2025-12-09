using MediatR;
using Mediatr.ApplicationLayer.Application.Events.QueryNotifications;

namespace Mediatr.ApplicationLayer.Application.Queries
{
    public interface IQuery<TData> : IRequest<IQueryNotification<TData>>;
}