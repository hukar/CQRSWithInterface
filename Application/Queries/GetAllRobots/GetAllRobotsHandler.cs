using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Application.Interfaces.Repository;
using CQRSWithInterface.Models;
using MediatR;

namespace CQRSWithInterface.Application.Queries.GetAllRobots;

public class GetAllRobotsHandler : IQueryHandler<GetAllRobotsQuery, IEnumerable<Robot>>
{
    private readonly IRobotRepository _robots;
    public GetAllRobotsHandler(IRobotRepository robots)
    {
            _robots = robots;
    }
    
    public async Task<IEnumerable<Robot>> Handle(GetAllRobotsQuery request, CancellationToken cancellationToken)
     => await _robots.GetAll();

}
