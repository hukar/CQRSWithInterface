using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Application.Interfaces.Repository;
using CQRSWithInterface.Models;

namespace CQRSWithInterface.Application.Commands;

public class CreateRobotHandler : ICommandHandler<CreateRobotCommand,Robot>
{
    private readonly IRobotRepository _robots;

    public CreateRobotHandler(IRobotRepository robots)
    {
        _robots = robots;
    }

    public Task<Robot> Handle(CreateRobotCommand request, CancellationToken cancellationToken)
     => await _robots.Create(new Robot { CodeName = request.CodeName});

}
