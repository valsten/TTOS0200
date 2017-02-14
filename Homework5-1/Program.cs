using Homework5_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Employee
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int Wheelsize { get; set; }

        public Employee(string model, string type, int wheelsize)
        {
            Model = model;
            Type = type;
            Wheelsize = wheelsize;
        }

        public override string ToString()
        {
            string s = "Employee \n Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary;
            return s;
        }
    }

    class Boss : Employee
    {
        public string Car { get; set; }
        public float Bonus { get; set; }


        public Boss(string name, string profession, float salary, string car, float bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            string s = "Boss \n Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary + ", Car: " + Car + ", Bonus: " + Bonus;
            return s;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee("Karl Marx", "Teacher", 1200);
        employees[1] = new Employee("Rosa Luxemburg", "Psychiatrist", 2500);
        employees[2] = new Employee("Friedirch Engels", "Doctor", 3000);

        Boss[] bosses = new Boss[2];
        bosses[0] = new Boss("Vladimir Lenin", "CEO", 2500, "Lada", 1500);
        bosses[1] = new Boss("Lev Trotsky", "Vice CEO", 2000, "Trabant", 1000);

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine(employees[i].ToString());
        }

        for (int i = 0; i <= 1; i++)
        {
            Console.WriteLine(bosses[i].ToString());
        }
    }
}
