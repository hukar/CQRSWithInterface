namespace CQRSWithInterface.Application.Queries.GetRobotById;

public record GetRobotByIdQuery(int Id) : IQuery<Robot?>;
