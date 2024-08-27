using HeadFirst.model;

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
            //Duck duck = new MallardDuck();
            //duck.PerformFly();
            //duck.PerformQuack();
            //duck.Quackable = new MuteQuack();
            //duck.PerformQuack();

            Character character = new King();
            character.Fight();
            character.WeaponBehavior = new BowAndArrowBehavior();
            character.Fight();
        }
    }
}
