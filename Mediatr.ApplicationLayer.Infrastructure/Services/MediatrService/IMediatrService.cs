using Mediatr.ApplicationLayer.Application.Commands;
using Mediatr.ApplicationLayer.Application.Queries;
using Mediatr.ApplicationLayer.Domain.Models.MediatrResult;

namespace Mediatr.ApplicationLayer.Infrastructure.Services.MediatrService
{
    public interface IMediatrService
    {
        Task<IMediatrResult> ProcessCommandAsync(ICommand command);
        
        Task<IMediatrResult<TData>> ProcessQueryAsync<TData>(IQuery<TData> query);
    }
}