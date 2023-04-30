using Distribt.Shared.Communication.Publishers.Integration;
using Distribt.Services.Subscriptions.Dtos;

var app = DefaultDistribtWebApplication.Create(builder =>
{
    builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

    builder.Services.AddServiceBusIntegrationPublisher(builder.Configuration);
});

app.MapReverseProxy();

app.MapGet("/", () => "Hello World from API.Public");

app.MapPost("/subscribe", async (SubscriptionDto subscriptionDto) =>
{
    IIntegrationMessagePublisher publisher = app.Services.GetRequiredService<IIntegrationMessagePublisher>();

    await publisher.Publish(subscriptionDto, routingKey: "subscription");
});

DefaultDistribtWebApplication.Run(app);