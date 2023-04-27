using Distribt.Shared.Api;

var app = DefaultDistribtWebApplication.Create(builder =>
{
    builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
});

app.MapReverseProxy();

app.MapGet("/", () => "Hello World from API.Public");

DefaultDistribtWebApplication.Run(app);