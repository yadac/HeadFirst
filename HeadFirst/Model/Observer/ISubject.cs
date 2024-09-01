namespace HeadFirst.Model.Observer
{
    public interface ISubject
    {
        void Regist(IObserver o);

        void Remove(IObserver o);

        void Notify();

    }
}
