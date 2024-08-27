using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public abstract class Duck
    {
        public IFlyable Flyable { get; set; }
        public IQuackable Quackable { get; set; }

        public void Quack()
        {
            Debug.WriteLine("Quack");
        }

        public void Swim()
        {
            Debug.WriteLine("Swim");
        }

        public abstract void Display();
        public void PerformFly()
        {
            Flyable.Fly();
        }
        public void PerformQuack()
        {
            Quackable.Quack();
        }

    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Flyable = new FlyWithWings();
            Quackable = new SQuack();
        }
        public override void Display()
        {
        }
    }

    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Debug.WriteLine("fly with wings");
        }
    }

    public class SQuack : IQuackable
    {
        public void Quack()
        {
            Debug.WriteLine("q-q-");
        }
    }
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Debug.WriteLine("...");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface IQuackable
    {
        void Quack();
    }
}
