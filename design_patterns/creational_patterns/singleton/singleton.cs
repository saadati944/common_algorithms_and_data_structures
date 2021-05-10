using System;
using System.Threading.Tasks;

namespace designPatterns
{
    class Singleton
    {
        private static Singleton _singleton;

        private readonly string message;

        private Singleton()
        {
            message = $"this instance was created in {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}";
        }
        
        public static Singleton GetInstance()
        {
            if (_singleton is null)
                _singleton = new Singleton();
            return _singleton;
        }

        public override string ToString()
        {
            return message;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine("get an instance of singleton class");
            Console.WriteLine("singleton1=>"+singleton1);
            Console.WriteLine("wait for 1 second");
            Task.Delay(1000).Wait();
            Console.WriteLine("trying to get another instance of it");
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine("singleton2=>"+singleton2);
        }
    }

}