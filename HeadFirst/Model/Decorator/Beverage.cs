namespace HeadFirst.Model.Decorator
{
    public abstract class Beverage
    {
        protected string _description;

        public abstract string GetDescription();

        public abstract double Cost();
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "HouseBlend";
        }
        public override double Cost()
        {
            return 1.0;
        }
        public override string GetDescription()
        {
            return _description;
        }
    }

    public class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;
        public BeverageDecorator(Beverage beverage, string description)
        {
            _beverage = beverage;
            _description = description;
        }

        public override double Cost()
        {
            return _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + $"_{_description}";
        }
    }

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

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage, "Milk")
        {
        }
        public override double Cost()
        {
            return base.Cost() + 0.3;
        }
    }

}
