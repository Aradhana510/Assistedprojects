using System;

// Adapter Pattern
interface ITarget
{
    void Request();
}

class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's SpecificRequest method called.");
    }
}

class Adapter : ITarget
{
    private Adaptee adaptee;

    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        adaptee.SpecificRequest();
    }
}

// Bridge Pattern
interface IImplementor
{
    void OperationImp();
}

class ConcreteImplementorA : IImplementor
{
    public void OperationImp()
    {
        Console.WriteLine("Concrete Implementor A - OperationImp method called.");
    }
}

class ConcreteImplementorB : IImplementor
{
    public void OperationImp()
    {
        Console.WriteLine("Concrete Implementor B - OperationImp method called.");
    }
}

abstract class Abstraction
{
    protected IImplementor implementor;

    public Abstraction(IImplementor implementor)
    {
        this.implementor = implementor;
    }

    public abstract void Operation();
}

class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        implementor.OperationImp();
    }
}

// Proxy Pattern
interface ISubject
{
    void Request();
}

class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject - Request method called.");
    }
}

class Proxy : ISubject
{
    private RealSubject realSubject;

    public Proxy()
    {
        realSubject = new RealSubject();
    }

    public void Request()
    {
        // Additional logic before calling the real subject's method
        Console.WriteLine("Proxy - Before Request");
        
        realSubject.Request();
        
        // Additional logic after calling the real subject's method
        Console.WriteLine("Proxy - After Request");
    }
}

// Decorator Pattern
interface IComponent
{
    void Operation();
}

class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent - Operation method called.");
    }
}

class Decorator : IComponent
{
    private IComponent component;

    public Decorator(IComponent component)
    {
        this.component = component;
    }

    public virtual void Operation()
    {
        component.Operation();
    }
}

class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorA - Additional operation.");
    }
}

class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("ConcreteDecoratorB - Additional operation.");
    }
}

// Composite Pattern
interface IComponentComposite
{
    void Operation();
}

class Leaf : IComponentComposite
{
    private string name;

    public Leaf(string name)
    {
        this.name = name;
    }

    public void Operation()
    {
        Console.WriteLine($"Leaf '{name}' - Operation method called.");
    }
}

class Composite : IComponentComposite
{
    private List<IComponentComposite> children = new List<IComponentComposite>();

    public void Add(IComponentComposite component)
    {
        children.Add(component);
    }

    public void Remove(IComponentComposite component)
    {
        children.Remove(component);
    }

    public void Operation()
    {
        Console.WriteLine("Composite - Operation method called.");
        foreach (var component in children)
        {
            component.Operation();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Adapter Pattern
        Adaptee adaptee = new Adaptee();
        ITarget adapter = new Adapter(adaptee);
        adapter.Request();

        // Bridge Pattern
        IImplementor implementorA = new ConcreteImplementorA();
        Abstraction abstractionA = new RefinedAbstraction(implementorA);
        abstractionA.Operation();

        IImplementor implementorB = new ConcreteImplementorB();
        Abstraction abstractionB = new RefinedAbstraction(implementorB);
        abstractionB.Operation();

        // Proxy Pattern
        ISubject proxy = new Proxy();
        proxy.Request();

        // Decorator Pattern
        IComponent component = new ConcreteComponent();
        IComponent decoratedComponentA = new ConcreteDecoratorA(component);
        IComponent decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);

        decoratedComponentB.Operation();

        // Composite Pattern
        IComponentComposite leaf1 = new Leaf("Leaf 1");
        IComponentComposite leaf2 = new Leaf("Leaf 2");

        Composite composite1 = new Composite();
        composite1.Add(leaf1);
        composite1.Add(leaf2);

        IComponentComposite leaf3 = new Leaf("Leaf 3");
        IComponentComposite leaf4 = new Leaf("Leaf 4");

        Composite composite2 = new Composite();
        composite2.Add(leaf3);
        composite2.Add(leaf4);

        Composite composite = new Composite();
        composite.Add(composite1);
        composite.Add(composite2);

        composite.Operation();
    }
}
