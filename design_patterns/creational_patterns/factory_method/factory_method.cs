using System;

namespace designPatterns
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public string Operation()
        {
            var product = FactoryMethod();
            return $"Doing some work with {product.Operation()}";
        }
    }
    class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
    class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
    public interface IProduct
    {
        string Operation();
    }
    class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "Result of productA";
        }
    }
    class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "Result of productB";
        }
    }
    class Client
    {
        public void Main()
        {
            Console.WriteLine("start the app with ConcreteCreatorA.");
            ClientCode(new ConcreteCreatorA());
            Console.WriteLine();
            Console.WriteLine("start the app with ConcreteCreatorB.");
            ClientCode(new ConcreteCreatorB());
        }
        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Creators class doesn't matter, operations are the same\n{creator.Operation()}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

}