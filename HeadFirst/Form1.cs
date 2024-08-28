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
            //Character character = new King();
            //character.Fight();
            //character.WeaponBehavior = new BowAndArrowBehavior();
            //character.Fight();

            NormalDisplayDevice device = new NormalDisplayDevice();
            WeatherData weather = new WeatherData();
            weather.Regist(device);
            weather.SetMeasurements();
            this.label1.Text = device.Display();
        }
    }
}
