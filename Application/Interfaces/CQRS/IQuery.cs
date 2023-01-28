namespace CQRSWithInterface.Application.Interfaces;

public interface IQuery<TResponse> : IRequest<TResponse> 
    where TResponse : class?
{
    
}
