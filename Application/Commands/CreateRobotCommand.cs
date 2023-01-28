namespace CQRSWithInterface.Application.Commands;

public record CreateRobotCommand(string CodeName) : ICommand<Robot>;

