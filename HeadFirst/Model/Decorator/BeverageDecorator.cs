namespace HeadFirst.Model.Decorator
{
    public class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;
        public BeverageDecorator(Beverage beverage, string description)
        {
            _beverage = beverage;
            _description = description;
            _size = beverage.GetSize();
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

}
