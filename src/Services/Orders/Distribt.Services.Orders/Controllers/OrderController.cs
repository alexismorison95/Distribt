using Microsoft.AspNetCore.Mvc;

namespace Distribt.Services.Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("{orderId}")]
        public Task<OrderDto> GetOrder(Guid orderId)
        {
            //TODO: logic
            return Task.FromResult(new OrderDto(orderId));
        }

        [HttpPost(Name = "addorder")]
        public Task<Guid> AddOrder(OrderDto order)
        {
            //TODO: logic
            return Task.FromResult(Guid.NewGuid());
        }


        //TODO: finish the dto
        //TODO: move
        public record OrderDto(Guid orderId);
    }
}
