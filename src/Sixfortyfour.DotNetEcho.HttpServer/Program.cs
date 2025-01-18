using Sixfortyfour.DotNetEcho.HttpServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Map("/echo", async (HttpRequest httpRequest) =>
{
    return await httpRequest.ToEchoResponseAsync();
});

app.Run();