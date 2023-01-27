using MediatR;

namespace CQRSWithInterface.Application.Interfaces;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>  
    where TQuery : IQuery<TResponse> 
    where TResponse : class
{
    
}


