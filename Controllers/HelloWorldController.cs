using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace BackendConCSharpYDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly ILogger<HelloWorldController> _logger;
    IHelloWorldService helloWorldService;

    TareasContext dbcontext;

    public HelloWorldController(
        IHelloWorldService helloWorld,
        ILogger<HelloWorldController> logger,
        TareasContext db
    )
    {
        helloWorldService = helloWorld;
        _logger = logger;
        dbcontext = db;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation(
            "Retornando infromación de la inyección de dependencia generada anteriormente."
        );
        return Ok(helloWorldService.GetHelloWorld());
    }

    //Para validar si la base de datos existe, en caso de no existir la va a crear, crea las tablas según los modelos e inserta los registros iniciales que hay en el código.
    [HttpGet]
    [Route("createdb")]
    public IActionResult CreateDatabase()
    {
        dbcontext.Database.EnsureCreated();
        return Ok();
    }
}
