using System;

namespace designPatterns
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }
        
        public Person ShallowCopy()
        {
            // Shallow copy creates new instance of the class and
            // copies all fields of first class to the second one
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            // Same as shallow copy but it creates new instances
            // for reference type fields (such as classes)
            Person clone = ShallowCopy();
            
            // copy reference type fields
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            
            // Strings are immutable and can't be changed, so there
            // is no need to create a new copy of them.
            clone.Name = Name;
            
            return clone;
        }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} BirthDate: {BirthDate.ToShortDateString()} {BirthDate.ToShortTimeString()} ID: {IdInfo.ToString()}";
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }

        public override string ToString()
        {
            return $"id_{IdNumber}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime popularDateTime = Convert.ToDateTime("1977-01-01");
            IdInfo popularIdInfo = new IdInfo(666);
            Person person = new Person();
            person.Age = 42;
            person.BirthDate = popularDateTime;
            person.Name = "Jack Daniels";
            person.IdInfo = popularIdInfo;

            Person shallowCopyPerson = person.ShallowCopy();
            Person deepCopyPerson = person.DeepCopy();
            
            Console.WriteLine("___Before any changes___");
            Console.WriteLine("Person:"+person);
            Console.WriteLine("shallow copy person:"+shallowCopyPerson);
            Console.WriteLine("deep copy person:"+deepCopyPerson);
            
            
            // changing
            person.Age = 54;
            deepCopyPerson.Name = "original person";
            
            popularDateTime = DateTime.Now;
            popularIdInfo.IdNumber += 10;
            
            deepCopyPerson.Name = "Shallow person";

            deepCopyPerson.IdInfo = new IdInfo(764);
            deepCopyPerson.Name = "Deep person";
            deepCopyPerson.BirthDate = DateTime.Now;


            Console.WriteLine("___After changes___");
            Console.WriteLine("Person:"+person);
            Console.WriteLine("shallow copy person:"+shallowCopyPerson);
            Console.WriteLine("deep copy person:"+deepCopyPerson);
        }
    }

}