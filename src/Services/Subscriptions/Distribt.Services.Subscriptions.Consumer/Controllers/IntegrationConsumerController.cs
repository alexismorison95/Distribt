using Distribt.Shared.Communication.Consumers.Host;
using Distribt.Shared.Communication.Consumers.Manager;
using Distribt.Shared.Communication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace Distribt.Services.Subscriptions.Consumer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IntegrationConsumerController : ConsumerController<IntegrationMessage>
    {
        public IntegrationConsumerController(IConsumerManager<IntegrationMessage> consumerManager) : base(consumerManager)
        {
        }
    }
}
