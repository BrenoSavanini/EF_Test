using Microsoft.AspNetCore.Mvc;
using EF_Test.Data;
using EF_Test.Domain.Interfaces;
using EF_Test.Domain.Models;

namespace EF_Test.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private IOrderRepository _orderRepository;
    public OrderController(ILogger<OrderController> logger, IOrderRepository orderRepository)
    {
        _logger = logger;
        _orderRepository = orderRepository;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var orders = _orderRepository.Get();
        return Ok(orders);
    }

    [HttpPost]
    public IActionResult Create([FromBody] Order order)
    {
        var createdOrder = _orderRepository.Create(order);
        return Ok(createdOrder);
    }
}
