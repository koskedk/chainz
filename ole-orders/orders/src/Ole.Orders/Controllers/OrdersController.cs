using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ole.Orders.Database;
using Ole.Orders.Models;

namespace Ole.Orders.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(OrderDto orderDto)
        {
            var order = Order.Create(orderDto);
            Store<Order>.Add(order);
            return Ok(new {order.Id});
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Store<Order>.Read());
        }
    }
}
