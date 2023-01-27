using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Models;

namespace CQRSWithInterface.Infrastructure;

public class RobotRepository : IRobotRepository
{
    private readonly List<Robot> _robots = new() {
        new(1, "CT-670"),
        new(2, "BBa-Bi-B0U"),
        new(1, "R0-BRT"),
    };
    
    public Robot Create(Robot robot)
    {
        _robots.Add(robot);

        return robot;
    }

    public List<Robot> GetAll() => _robots;
}
