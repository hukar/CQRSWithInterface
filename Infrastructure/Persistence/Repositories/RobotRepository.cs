namespace CQRSWithInterface.Infrastructure.Persistence.Repositories;

public class RobotRepository : IRobotRepository
{
    private readonly List<Robot> _robots = new() {
        new(1, "CT-670"),
        new(2, "BBa-Bi-B0U"),
        new(3, "R0-BRT"),
    };

    public async Task<IEnumerable<Robot>> GetAll()
    {
        await Task.Delay(500);

        return _robots;
    }

    public async Task<Robot?> GetById(int id)
    {
        await Task.Delay(500);

        return _robots.Where(r => r.Id == id).SingleOrDefault();
    }

    public async Task<Robot> Create(Robot robotToCreate)
    {
        await Task.Delay(500);

        var id = _robots.Select(r => r.Id).DefaultIfEmpty(0).Max() + 1;
        var robotCreated = new Robot(id, robotToCreate.CodeName);
        
        _robots.Add(robotCreated);

        return robotCreated;
    }
}
