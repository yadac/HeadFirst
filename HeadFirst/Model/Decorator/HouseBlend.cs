namespace HeadFirst.Model.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(BeverageSize size)
        {
            _description = "HouseBlend";
            _size = size;
        }
        public override double Cost()
        {
            switch (_size)
            {
                case BeverageSize.TALL:
                    return 1.0;
                case BeverageSize.GRANDE:
                    return 2.0;
                case BeverageSize.VENTI:
                    return 3.0;
                default:
                    throw new InvalidOperationException();
            }
        }
        public override string GetDescription()
        {
            return _description;
        }
    }

}
