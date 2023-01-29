var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRobotRepository, RobotRepository>();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapGet("/test/exception", async () => {
    await Task.Delay(TimeSpan.FromMilliseconds(500));

    throw new Exception("Badaboum boum");
});

app.MapRobots();


app.Run();
