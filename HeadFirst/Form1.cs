using HeadFirst.Model.Decorator;
using HeadFirst.Model.Observer;

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

        private void button2_Click(object sender, EventArgs e)
        {
            // HouseBlendの作成
            HouseBlend houseBlend = new HouseBlend(BeverageSize.VENTI);
            // Mochaのトッピング
            Mocha mocha = new Mocha(houseBlend);
            // Mochaのトッピング
            Mocha mocha2 = new Mocha(mocha);
            // Milkのトッピング
            Milk milk = new Milk(mocha2);
            // お会計(1 + 0.2 * 2 + 0.3 = $1.7)
            var cost = milk.Cost();
            label1.Text = $"Cost: ${cost.ToString()}";
            label2.Text = $"Order: {milk.GetDescription()}";
        }
    }
}
