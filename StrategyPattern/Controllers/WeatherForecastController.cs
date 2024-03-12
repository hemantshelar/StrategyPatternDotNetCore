using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Services;

namespace StrategyPattern.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class WeatherForecastController : ControllerBase
	{
		public readonly IExportServiceProvider _exportServiceProvider;
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger, IExportServiceProvider exportServiceProvider)
		{
			_logger = logger;
			_exportServiceProvider = exportServiceProvider;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}

		[HttpGet(Name = "ExportData")]
		public string ExportData(string fileType, string data)
		{
			return _exportServiceProvider.exportData(fileType, data);
		}
	}
}
