namespace Mediatr.ApplicationLayer.Domain.Models.MediatrResult
{
    public interface IMediatrResult
    {
        bool IsSuccess { get;  }
    }
    
    public interface IMediatrResult<TData> : IMediatrResult
    {
        TData Data { get; }
    }
}