using HeadFirst.Model.Observer;
using Newtonsoft.Json;

namespace HeadFirst.Service.Observer
{
    public static class WeatherElementGenerator
    {
        private static readonly HttpClient client = new HttpClient();
        private static Weather _weather = new Weather();
        private static readonly object lockObject = new object();
        private static DateTime lastUpdated = DateTime.MinValue;

        public static async Task<double> GetTempretureAsync()
        {
            await UpdateWeatherIfNeedsAsync();
            return _weather.Current?.Temperature2m ?? 0;
        }

        public static async Task<double> GetHumidityAsync()
        {
            await UpdateWeatherIfNeedsAsync();
            return _weather.Current?.RelativeHumidity2m ?? 0;
        }

        private static async Task UpdateWeatherIfNeedsAsync()
        {
            lock (lockObject)
            {
                if ((DateTime.Now - lastUpdated).TotalHours < 1)
                {
                    return;
                }
            }
            await FetchWeatherAsync();
        }

        private static async Task FetchWeatherAsync()
        {
            string apiUrl = "https://api.open-meteo.com/v1/forecast?latitude=35.6895&longitude=139.6917&current=temperature_2m,relative_humidity_2m&timezone=Asia%2FTokyo";
            try
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(jsonResponse))
                    {
                        Weather weather = JsonConvert.DeserializeObject<Weather>(jsonResponse);
                        if (weather != null && weather.Current != null)
                        {
                            lock (lockObject)
                            {
                                _weather = weather;
                                lastUpdated = DateTime.Now;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }
    }
}
