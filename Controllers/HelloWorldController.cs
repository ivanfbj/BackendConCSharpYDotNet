using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace BackendConCSharpYDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;
    IHelloWorldService helloWorldService;

    public HelloWorldController(IHelloWorldService helloWorld, ILogger<HelloWorldController> logger)
    {
        helloWorldService = helloWorld;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Retornando infromación de la inyección de dependencia generada anteriormente.");
        return Ok(helloWorldService.GetHelloWorld());
    }
}
