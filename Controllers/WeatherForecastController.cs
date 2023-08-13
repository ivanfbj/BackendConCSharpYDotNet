using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BackendConCSharpYDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        if (ListWeatherForecast == null || !ListWeatherForecast.Any())
        {
            ListWeatherForecast = Enumerable
                .Range(1, 5)
                .Select(
                    index =>
                        new WeatherForecast
                        {
                            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                            TemperatureC = Random.Shared.Next(-20, 55),
                            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                        }
                )
                .ToList();
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    //[Route("get/weatherforecast")]
    //[Route("get/weatherforecast2")]
    //[Route("[action]")] //Permite que el nombre de la ruta sea el mismo nombre del método que se usa.
    public IEnumerable<WeatherForecast> Get()
    {
        // Estos mensajes escritos con el logger van a ir apareciendo en la consola.
        // Y pueden ser leidos por diferentes servicios para tener trazabilidad de Logs.
        // _logger.LogInformation("Retornando la lista de WeatherForecast");
        
        // Existen diferente tipo de LOG en el ILogger, Trace, Debug, Information, Warning, Error, Critical, None
        //  En el appsettings.Development.json y appsettings.json se configurar el nivel de acceso para el ILogger
        //  Por lo cual dependiendo del cual este configurado si mostrará o no el mensaje que se requiera mostrar, en el LogInformation 
        //  o  LogDebug.
        _logger.LogDebug("Retornando la lista de WeatherForecast");
        return ListWeatherForecast;
    }

    [HttpPost]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        ListWeatherForecast.Add(weatherForecast);

        return Ok();
    }

    [HttpDelete("{index}")]
    public IActionResult Delete(int index)
    {
        ListWeatherForecast.RemoveAt(index);

        return Ok();
    }

}
