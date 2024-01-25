using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ProgTechniques.OptionsConfigPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //o IOptionsMonitor � um singleton que monitora as mudan�as na configura��o
        private readonly IOptionsMonitor<WeatherOptions> _weatherOptions;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        //� necess�rio injetar o IOptionsMonitor no construtor para que o singleton seja criado
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IOptionsMonitor<WeatherOptions> weatherOptions)
        {
            _logger = logger;
            _weatherOptions = weatherOptions;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            WeatherOptions options = _weatherOptions.CurrentValue;

            //verifica se a configura��o customizada est� habilitada (se EnableOptionsWeatherForecast � true)
            if (options.EnableOptionsWeatherForecast)
            {
                //se sim, passa os valores da configura��o como par�metro
                return WeatherForecastEnumerable(options.MinTemperatureCelsius, options.MaxTemperatureCelsius, options.FixedSummary);
            }
            else
            {
                return WeatherForecastEnumerable(-20, 55);
            }
        }

        private IEnumerable<WeatherForecast> WeatherForecastEnumerable(int minTemperature, int maxTemperature, string fixedSummary = null)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(minTemperature, maxTemperature),
                Summary = fixedSummary ?? Summaries[Random.Shared.Next(Summaries.Length)]
            })
                .ToArray();
        }
    }
}
