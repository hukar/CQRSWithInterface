using CQRSWithInterface.Models;

namespace CQRSWithInterface.Application.Interfaces;

public interface IRobotRepository
{
    List<Robot> GetAll();
    Robot Create(Robot robot);
}
