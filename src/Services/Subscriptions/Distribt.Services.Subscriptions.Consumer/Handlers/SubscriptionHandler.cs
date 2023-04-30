using Distribt.Services.Subscriptions.Dtos;
using Distribt.Shared.Communication.Consumers.Handler;
using Distribt.Shared.Communication.Messages;

namespace Distribt.Services.Subscriptions.Consumer.Handlers
{
    public class SubscriptionHandler : IIntegrationMessageHandler<SubscriptionDto>
    {
        public Task Handle(IntegrationMessage<SubscriptionDto> message, CancellationToken cancelToken = default(CancellationToken))
        {
            Console.WriteLine($"Email {message.Content.Email} successfully subscribed.");

            return Task.CompletedTask;
        }
    }
}
