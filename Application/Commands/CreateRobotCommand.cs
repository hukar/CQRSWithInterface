using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Models;

namespace CQRSWithInterface.Application.Commands;

public record CreateRobotCommand(string CodeName) : ICommand<Robot>;

