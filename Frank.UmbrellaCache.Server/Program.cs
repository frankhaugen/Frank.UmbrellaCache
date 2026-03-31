using Frank.UmbrellaCache.Server;
using Frank.BedrockSlim.Server;

var builder = Host.CreateApplicationBuilder(args);


builder.Services.AddHostedService<Worker>();

var host = builder.Build();

host.Run();
