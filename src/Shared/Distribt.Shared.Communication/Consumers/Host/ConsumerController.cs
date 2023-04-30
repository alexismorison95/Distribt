using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Distribt.Shared.Communication.Consumers.Manager;

namespace Distribt.Shared.Communication.Consumers.Host
{
    public class ConsumerController<TMessage> : Controller
    {
        private readonly IConsumerManager<TMessage> _consumerManager;

        public ConsumerController(IConsumerManager<TMessage> consumerManager)
        {
            _consumerManager = consumerManager;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("start")]
        public virtual IActionResult Start()
        {
            _consumerManager.RestartExecution();

            return Ok();
        }
    }
}
