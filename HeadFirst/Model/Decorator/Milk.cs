namespace HeadFirst.Model.Decorator
{
    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage, "Milk")
        {
        }
        public override double Cost()
        {
            switch (_size)
            {   
                case BeverageSize.TALL:
                    return base.Cost() + 0.1;
                case BeverageSize.GRANDE:
                    return base.Cost() + 0.2;
                case BeverageSize.VENTI:
                    return base.Cost() + 0.3;
                default:
                    throw new InvalidOperationException("Unknown Size");
            }
        }
    }
}
