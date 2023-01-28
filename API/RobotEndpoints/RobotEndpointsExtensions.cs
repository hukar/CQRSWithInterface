namespace CQRSWithInterface.API.RobotEndpoints;

public static class RobotEndpointsExtensions
{
    public static WebApplication MapRobots(this WebApplication app)
    {
        var route = app.MapGroup("/robots");

        route.MapGet("/", async (ISender sender) => await sender.Send(new GetAllRobotsQuery()));

        route.MapGet("/{id:int}", async (ISender sender, int id) => await sender.Send(new GetRobotByIdQuery(id)));

        route.MapPost("/", async (ISender sender, CreateRobotCommand command)
            => await sender.Send(command));

        return app;
    }
}
