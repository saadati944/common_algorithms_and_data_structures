using System;

namespace designPatterns
{
    class Program
    {
        public interface IAbstractFactory
    {
        IAbstractProductA createProductA();
        IAbstractProductB createProductB();
    }
    public interface IAbstractProductA
    {
        string func1();
    }
    public interface IAbstractProductB
    {
        string func1();
        string func2(IAbstractProductA input);
    }

    class ConcreteFactoryReds : IAbstractFactory
    {
        public IAbstractProductA createProductA()
        {
            return new ConcreteProductAred();
        }

        public IAbstractProductB createProductB()
        {
            return new ConcreteProductBred();
        }
    }
    class ConcreteFactoryBlues : IAbstractFactory
    {
        public IAbstractProductA createProductA()
        {
            return new ConcreteProductAblue();
        }

        public IAbstractProductB createProductB()
        {
            return new ConcreteProductBblue();
        }
    }

    class ConcreteProductAred : IAbstractProductA
    {
        public string func1()
        {
            return "red A result";
        }
    }
    
    class ConcreteProductAblue : IAbstractProductA
    {
        public string func1()
        {
            return "blue A result";
        }
    }
    class ConcreteProductBred : IAbstractProductB
    {
        public string func1()
        {
            return "red B result";
        }

        public string func2(IAbstractProductA input)
        {
            return $"red B acts with {input.func1()}";
        }
    }
    
    class ConcreteProductBblue : IAbstractProductB
    {
        public string func1()
        {
            return "blue B result";
        }
        
        public string func2(IAbstractProductA input)
        {
            return $"blue B acts with {input.func1()}";
        }
    }

    class Client
    {
        public void start()
        {
            Console.WriteLine("interacting with red products:");
            interact(new ConcreteFactoryReds());
            
            Console.WriteLine();
            Console.WriteLine("interacting with blue products:");
            interact(new ConcreteFactoryBlues());
        }
        public void interact(IAbstractFactory factory)
        {
            Console.WriteLine(factory.createProductB().func2(factory.createProductA()));
        }
    }
        static void Main(string[] args)
        {
            new Client().start();
        }
    }
}