using MediatR;

namespace Mediatr.ApplicationLayer.Application.Events.QueryNotifications
{
    public interface IQueryNotification<TData> : INotification
    {
        TData Data { get; }
        
        bool IsSuccess { get; }
    }
}