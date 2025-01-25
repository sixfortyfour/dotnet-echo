using Serilog;
using Sixfortyfour.DotNetEcho.HttpServer;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("/applogs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Starting up");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.Map("/echo", async (HttpRequest httpRequest) =>
{
    var echoResponse = await httpRequest.ToEchoResponseAsync();

    Log.Information<EchoResponse>($"{echoResponse.Method}", echoResponse);

    return echoResponse;
});

app.Run();