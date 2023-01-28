namespace CQRSWithInterface.Application.Queries.GetAllRobots;

public record GetAllRobotsQuery : IQuery<IEnumerable<Robot>>;