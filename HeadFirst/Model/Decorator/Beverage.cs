namespace HeadFirst.Model.Decorator
{
    public abstract class Beverage
    {
        protected string _description;

        protected BeverageSize _size;

        public abstract string GetDescription();

        public abstract double Cost();

        public BeverageSize GetSize() { return _size; }
    }
}
