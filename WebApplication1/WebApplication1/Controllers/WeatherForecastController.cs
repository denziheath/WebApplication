using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast(
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55),
                Summaries[Random.Shared.Next(Summaries.Length)])).ToArray();
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IEnumerable<Person> GetPerson()
        {
            return new SeedData().PopulateAllPerson();
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public Person? GetPersonByName(string name)
        {
            try
            {
                return new SeedData().PopulateAllPerson().FirstOrDefault(x => x.Name == name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public Address? GetPersonAddressByName(string name)
        {
            return new SeedData().PopulateAllPerson().FirstOrDefault(x => x.Name == name)?.Address;
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public Person PostPerson(Person person)
        {
            return person;
        }

    }
}
