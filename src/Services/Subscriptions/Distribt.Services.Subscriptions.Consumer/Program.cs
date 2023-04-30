using Distribt.Services.Subscriptions.Consumer.Handler;
using Distribt.Shared.Api;
using Distribt.Shared.Communication.Consumer.Handler;
using Distribt.Shared.Communication.Consumers.Handler;
using Distribt.Shared.Setup;

WebApplication app = DefaultDistribtWebApplication.Create(builder =>
{
    builder.Services.AddHandlers(new List<IMessageHandler>()
    {
        new SubscriptionHandler(),
        new UnSubscriptionHandler()
    });

    builder.Services.AddServiceBusIntegrationConsumer(builder.Configuration);
});


DefaultDistribtWebApplication.Run(app);
