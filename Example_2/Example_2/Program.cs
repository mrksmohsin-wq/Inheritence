using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Person
    {
        public string Name;
        public int Age;

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
    class Student : Person
    {
        public string RollNumber;

        public void Study()
        {
            Console.WriteLine(Name + " is studying.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Mohsin"; // inherited
            s.Age = 20; //inherited 
            s.RollNumber = "CS101"; // owned
            s.DisplayInfo(); // Inherited method
            s.Study(); // owned method
        }
    }
}
