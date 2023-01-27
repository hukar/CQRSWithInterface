using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CQRSWithInterface.Application.Interfaces;

public interface IQuery<TResponse> : IRequest<TResponse> 
    where TResponse : class
{
    
}
