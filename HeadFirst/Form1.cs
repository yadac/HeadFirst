using HeadFirst.Model;

namespace HeadFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherData weatherData = new WeatherData();
            CurrentDisplay current = new CurrentDisplay(weatherData);
            ForecastDisplay forecast = new ForecastDisplay(weatherData);
            weatherData.SetMeasurements();
        }
    }
}
