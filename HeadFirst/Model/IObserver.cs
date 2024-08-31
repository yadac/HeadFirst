namespace HeadFirst.Model
{
    public interface IObserver
    {
        void Update(float templature, float humidity, float pressure);
    }
}
