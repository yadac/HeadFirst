namespace HeadFirst.Model
{
    public interface ISubject
    {
        void Regist(IObserver o);

        void Remove(IObserver o);

        void Notify();

    }
}
