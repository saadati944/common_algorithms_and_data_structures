using System;
using System.Collections.Generic;
using System.Text;

namespace designPatterns
{
    interface IBuilder
    {
        public void AddWindows(int count);
        public void AddWalls(int count);
        public void AddFloors(int count);
        public void Paint(String color);
        public House GetHouse();
        public void Reset();
    }

    class HouseBuilder : IBuilder
    {
        private House _house = new House();

        public void AddWindows(int count)
        {
            _house.AddPart($"Windows: {count}");
        }

        public void AddWalls(int count)
        {
            _house.AddPart($"Walls: {count}");
        }

        public void AddFloors(int count)
        {
            _house.AddPart($"Floors: {count}");
        }

        public void Paint(string color)
        {
            _house.AddPart($"Color: {color}");
        }

        public House GetHouse()
        {
            return _house;
        }

        public void Reset()
        {
            _house = new House();
        }
    }

    class House
    {
        private List<object> _parts = new List<object>();

        public void AddPart(string part)
        {
            this._parts.Add(part);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < _parts.Count; i++)
            {
                if (i != 0)
                    s.Append(", ");
                s.Append(_parts[i]);
            }

            return s.ToString();
        }
    }

    class Director
    {
        private IBuilder _builder = new HouseBuilder();

        public House CreateApartment()
        {
            _builder.Reset();
            _builder.AddFloors(10);
            _builder.AddWalls(40);
            _builder.AddWindows(20);
            _builder.Paint("gray");
            return _builder.GetHouse();
        }

        public House CreateBeachHouse()
        {
            _builder.Reset();
            _builder.AddFloors(1);
            _builder.AddWalls(6);
            _builder.AddWindows(6);
            _builder.Paint("brown");
            return _builder.GetHouse();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            
            House apartment = d.CreateApartment();
            House beachHouse = d.CreateBeachHouse();
            
            Console.WriteLine("apartment :");
            Console.WriteLine(apartment);
            
            Console.WriteLine("beach house :");
            Console.WriteLine(beachHouse);
        }
    }
}