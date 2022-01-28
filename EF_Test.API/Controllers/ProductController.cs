using Microsoft.AspNetCore.Mvc;
using EF_Test.Data;
using EF_Test.Domain.Interfaces;
using EF_Test.Domain.Models;

namespace EF_Test.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private IProductRepository _productRepository;
    public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
    {
        _logger = logger;
        _productRepository = productRepository;
    }

    [HttpPost]
    public IActionResult Create([FromBody] Product product)
    {
        var createdProduct = _productRepository.Create(product);
        return Ok(createdProduct);
    }
}
