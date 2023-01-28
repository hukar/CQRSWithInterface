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
