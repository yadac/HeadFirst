namespace HeadFirst.Model.Decorator
{
    public class Mocha : BeverageDecorator
    {
        public Mocha(Beverage beverage) : base(beverage, "Mocha")
        {
        }
        public override double Cost()
        {
            return base.Cost() + 0.2;
        }
    }

}
