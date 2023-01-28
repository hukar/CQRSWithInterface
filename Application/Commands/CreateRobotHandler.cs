namespace CQRSWithInterface.Application.Commands;

public class CreateRobotHandler : ICommandHandler<CreateRobotCommand,Robot>
{
    private readonly IRobotRepository _robots;

    public CreateRobotHandler(IRobotRepository robots)
    {
        _robots = robots;
    }

    public async Task<Robot> Handle(CreateRobotCommand request, CancellationToken cancellationToken)
     => await _robots.Create(new Robot(0, request.CodeName));
}
