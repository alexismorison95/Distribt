using Distribt.Shared.Api;

var app = DefaultDistribtWebApplication.Create();

app.MapGet("/", () => "Hello World from API.Public");

DefaultDistribtWebApplication.Run(app);