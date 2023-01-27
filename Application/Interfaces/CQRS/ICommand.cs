using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CQRSWithInterface.Application.Interfaces;

public interface ICommand : IRequest<int> { }
public interface ICommand<TResponse> : IRequest<TResponse> 
    where TResponse : class
{ }
