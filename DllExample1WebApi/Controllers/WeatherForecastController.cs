using Microsoft.AspNetCore.Mvc;
using Package1;
using Package2;

namespace DllExample1WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public void Get()
    {
        ClassPackage1 classtest = new ClassPackage1();
        classtest.UseSharedPackageMethod();

        ClassPackage2 classtest2 = new ClassPackage2();
        classtest2.UseSharedPackageMethod();

        // console output
        // Hello World version 2
        // Hello World version 2
    }
}
