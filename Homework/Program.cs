using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Vehicle
    {

        public Vehicle(string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }

        // Properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // Methods
        public void PrintData()
        {
            Console.WriteLine("Vehicle: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            string s = Name + ", " + Speed + ", " + Tyres;
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle0 = new Homework.Vehicle("Toyota", 60, 12);
            Vehicle vehicle1 = new Homework.Vehicle("Fiat", 45, 15);
            Vehicle vehicle2 = new Homework.Vehicle("Skoda", 55, 20);
            Vehicle vehicle3 = new Homework.Vehicle("Subaru", 80, 14);

            vehicle0.PrintData();
            vehicle1.PrintData();
            vehicle2.PrintData();
            vehicle3.PrintData();

            Console.WriteLine("Data in one string: ");
            Console.WriteLine(vehicle0.ToString());
            Console.WriteLine(vehicle1.ToString());
            Console.WriteLine(vehicle2.ToString());
            Console.WriteLine(vehicle3.ToString());

        }
    }
}
