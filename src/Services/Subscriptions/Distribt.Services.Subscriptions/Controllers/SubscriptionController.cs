using Distribt.Services.Subscriptions.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Distribt.Services.Subscriptions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        [HttpPost(Name = "subscribe")]
        public Task<bool> Subscribe(SubscriptionDto subscription)
        {
            //TODO: logic 
            return Task.FromResult(true);
        }

        [HttpDelete(Name = "unsubscribe")]
        public Task<bool> Unsubscribe(SubscriptionDto subscription)
        {
            //TODO: logic 
            return Task.FromResult(true);
        }
    }
}
