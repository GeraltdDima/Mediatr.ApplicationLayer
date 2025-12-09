using MediatR;
using Mediatr.ApplicationLayer.Application.Commands;
using Mediatr.ApplicationLayer.Application.Queries;
using Mediatr.ApplicationLayer.Domain.Models.MediatrResult;

namespace Mediatr.ApplicationLayer.Infrastructure.Services.MediatrService
{
    public abstract class MediatrService : IMediatrService
    {
        private readonly IMediator _mediator;
        
        public MediatrService(IMediator mediator) => _mediator = mediator;

        public virtual async Task<IMediatrResult> ProcessCommandAsync(ICommand command)
        {
            var notification = await _mediator.Send(command);
            await _mediator.Publish(notification);

            return new MediatrResult(notification.IsSuccess);
        }

        public virtual async Task<IMediatrResult<TData>> ProcessQueryAsync<TData>(IQuery<TData> query)
        {
            var notification = await _mediator.Send(query);
            await _mediator.Publish(notification);
            
            return new MediatrResult<TData>(notification.IsSuccess, notification.Data);
        }
    }
}