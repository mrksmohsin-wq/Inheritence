using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    class Example_1
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Eat();   // inherited method
            d.Bark();  // own method

        }
    }
}
