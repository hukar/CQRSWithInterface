namespace CQRSWithInterface.Application.Interfaces;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, int>
    where TCommand : ICommand
{ }
public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : class
{ }


