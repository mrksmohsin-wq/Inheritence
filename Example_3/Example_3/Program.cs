using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Vehicle
    {
        public string Brand;
        public int Speed;

        public void Start()
        {
            Console.WriteLine(Brand + " vehicle is starting.");
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoors;

        public void Honk()
        {
            Console.WriteLine(Brand + " car is honking.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Speed = 120;
            car.Start();
            car.Honk();
        }
    }
}
