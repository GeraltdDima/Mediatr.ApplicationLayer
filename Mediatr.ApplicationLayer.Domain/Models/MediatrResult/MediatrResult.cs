namespace Mediatr.ApplicationLayer.Domain.Models.MediatrResult
{
    public record MediatrResult(bool IsSuccess) : IMediatrResult;
    
    public record MediatrResult<TData>(bool IsSuccess, TData Data) : IMediatrResult<TData>;
}