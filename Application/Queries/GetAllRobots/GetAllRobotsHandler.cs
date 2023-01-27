using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Models;
using MediatR;

namespace CQRSWithInterface.Application.Queries.GetAllRobots;

public class GetAllRobotsHandler : IQueryHandler<GetAllRobotsQuery, List<Robot>>
{
    private readonly IRobotRepository _robots;
    public GetAllRobotsHandler(IRobotRepository robots)
    {
            _robots = robots;
    }
    
    public async Task<List<Robot>> Handle(GetAllRobotsQuery request, CancellationToken cancellationToken)
    {
        await Task.Delay(500);
        return _robots.GetAll();
    }

}
