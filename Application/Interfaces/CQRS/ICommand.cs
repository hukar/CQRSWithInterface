namespace CQRSWithInterface.Application.Interfaces;

public interface ICommand : IRequest<int> { }
public interface ICommand<TResponse> : IRequest<TResponse> 
    where TResponse : class
{ }
