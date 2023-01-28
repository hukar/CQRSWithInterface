namespace CQRSWithInterface.Application.Queries.GetRobotById;

public class GetRobotByIdHandler : IQueryHandler<GetRobotByIdQuery, Robot?>
{
    private readonly IRobotRepository _robots;

    public GetRobotByIdHandler(IRobotRepository robots)
    {
        _robots = robots;
    }

    public async Task<Robot?> Handle(GetRobotByIdQuery request, CancellationToken cancellationToken) => await _robots.GetById(request.Id);
}
