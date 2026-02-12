namespace WebApplication1.Models
{
    public class WeatherForecast
    {
        private DateTime dateTime;
        private int v1;
        private string v2;

        public WeatherForecast(DateTime dateTime, int v1, string v2)
        {
            this.dateTime = dateTime;
            this.v1 = v1;
            this.v2 = v2;
        }

        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
