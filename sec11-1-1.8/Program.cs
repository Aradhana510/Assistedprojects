using System;
using System.Collections.Generic;

namespace BehavioralDesignPatterns
{
    // Observer Design Pattern
    public interface IObserver
    {
        void Update(string message);
    }

    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public void SetMessage(string message)
        {
            this.message = message;
            Notify();
        }
    }

    public class ConcreteObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Received message: " + message);
        }
    }

    // Template Method Design Pattern
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Executing common steps...");
            Step1();
            Step2();
        }

        protected abstract void Step1();
        protected abstract void Step2();
    }

    public class ConcreteClassA : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("Step 1 from ConcreteClassA");
        }

        protected override void Step2()
        {
            Console.WriteLine("Step 2 from ConcreteClassA");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("Step 1 from ConcreteClassB");
        }

        protected override void Step2()
        {
            Console.WriteLine("Step 2 from ConcreteClassB");
        }
    }

    // Strategy Design Pattern
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy A");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy B");
        }
    }

    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Observer Pattern
            Subject subject = new Subject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            subject.Attach(observer1);
            subject.Attach(observer2);

            subject.SetMessage("Hello observers!");

            subject.Detach(observer2);

            subject.SetMessage("Observer2 has been detached.");

            Console.WriteLine();

            // Template Method Pattern
            AbstractClass classA = new ConcreteClassA();
            AbstractClass classB = new ConcreteClassB();

            classA.TemplateMethod();
            classB.TemplateMethod();

            Console.WriteLine();

            // Strategy Pattern
            Context contextA = new Context(new ConcreteStrategyA());
            Context contextB = new Context(new ConcreteStrategyB());

            contextA.ExecuteStrategy();
            contextB.ExecuteStrategy();

            Console.ReadLine();
        }
    }
}
