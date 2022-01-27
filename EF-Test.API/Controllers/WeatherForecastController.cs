using Microsoft.AspNetCore.Mvc;
using EF_Test.Data;
using EF_Test.Data.Interfaces;

namespace EF_Test.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private IOrderRepository _orderRepository;
    public WeatherForecastController(ILogger<WeatherForecastController> logger, IOrderRepository orderRepository)
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
}
