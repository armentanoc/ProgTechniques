namespace ProgTechniques.OptionsConfigPattern
{
    public class WeatherOptions
    {
        public bool EnableOptionsWeatherForecast { get; set; }
        public int MinTemperatureCelsius { get; set; }
        public int MaxTemperatureCelsius { get; set; }
        public string? FixedSummary { get; set; }
        
    }
}
