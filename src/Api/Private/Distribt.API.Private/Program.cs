
var app = DefaultDistribtWebApplication.Create();

app.MapGet("/", () => "Hello World from API.Private");

DefaultDistribtWebApplication.Run(app);