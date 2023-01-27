using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Infrastructure.Persistence.Repositories;
using CQRSWithInterface.Models;

namespace CQRSWithInterface.Application.Queries.GetRobotById;

public class GetRobotByIdHandler : IQueryHandler<GetRobotByIdQuery, Robot?>
{
    private readonly RobotRepository _robots;

    public GetRobotByIdHandler(RobotRepository robots)
    {
        _robots = robots;
    }

    public Task<Robot?> Handle(GetRobotByIdQuery request, CancellationToken cancellationToken)
    {
        
    }
}
