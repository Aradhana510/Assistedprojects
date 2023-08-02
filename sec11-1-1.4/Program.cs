using System;

public abstract class AbstractFactory
{
    public abstract ProductA CreateProductA();
    public abstract ProductB CreateProductB();
}

public class ConcreteFactory1 : AbstractFactory
{
    public override ProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override ProductB CreateProductB()
    {
        return new ProductB1();
    }
}

public class ConcreteFactory2 : AbstractFactory
{
    public override ProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override ProductB CreateProductB()
    {
        return new ProductB2();
    }
}

public abstract class ProductA
{
    public abstract void DisplayInfo();
}

public abstract class ProductB
{
    public abstract void DisplayInfo();
}

public class ProductA1 : ProductA
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Product A1");
    }
}

public class ProductA2 : ProductA
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Product A2");
    }
}

public class ProductB1 : ProductB
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Product B1");
    }
}

public class ProductB2 : ProductB
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Product B2");
    }
}

public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }

    public void SomeMethod()
    {
        // Add some functionality here
    }
}

public interface IFactory
{
    Product CreateProduct();
}

public class ConcreteFactory : IFactory
{
    public Product CreateProduct()
    {
        return new Product();
    }
}

public class Product
{
    public void DisplayInfo()
    {
        Console.WriteLine("Product");
    }
}

public interface IPrototype
{
    IPrototype Clone();
}

public class ConcretePrototype : IPrototype
{
    public IPrototype Clone()
    {
        // Implement the cloning logic here
        return (IPrototype)MemberwiseClone();
    }
}

class Program
{
    static void Main()
    {
        // Abstract Factory
        AbstractFactory factory1 = new ConcreteFactory1();
        ProductA productA1 = factory1.CreateProductA();
        ProductB productB1 = factory1.CreateProductB();
        productA1.DisplayInfo(); // Output: Product A1
        productB1.DisplayInfo(); // Output: Product B1

        AbstractFactory factory2 = new ConcreteFactory2();
        ProductA productA2 = factory2.CreateProductA();
        ProductB productB2 = factory2.CreateProductB();
        productA2.DisplayInfo(); // Output: Product A2
        productB2.DisplayInfo(); // Output: Product B2

        // Singleton
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;
        Console.WriteLine(singleton1 == singleton2); // Output: True (only one instance)

        // Factory Method
        IFactory factory = new ConcreteFactory();
        Product product = factory.CreateProduct();
        product.DisplayInfo(); // Output: Product

        // Prototype
        ConcretePrototype prototype = new ConcretePrototype();
        ConcretePrototype clonedPrototype = (ConcretePrototype)prototype.Clone();
        Console.WriteLine(prototype == clonedPrototype); // Output: False (different instances)

        Console.ReadLine();
    }
}
