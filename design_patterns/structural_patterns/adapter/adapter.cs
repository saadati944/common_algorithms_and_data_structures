using System;
using System.Threading.Tasks;

namespace designPatterns
{
    public interface ITarget
    {
        string Request();
    }
    class Adaptee
    {
        public string SpecificRequest()
        {
            return ">>Specific request<<";
        }
    }
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Request()
        {
            return $"{_adaptee.SpecificRequest().Replace("<<", "\"").Replace(">>", "\"")} (changed)";
        }
    }

    class Program
    {
        static void Main()
        {
            //Adaptee has incompatible interface with the client.
            Adaptee adaptee = new Adaptee();
            //operate(adaptee); //this is wrong !!!
            
            
            ITarget target = new Adapter(adaptee);
            operate(target);
        }

        static void operate(ITarget target)
        {
            Console.WriteLine(target.Request());
        }
    }

}