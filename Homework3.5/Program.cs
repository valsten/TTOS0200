using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._5
{
    class Student
    {
        public string Number { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }

        public Student(string number, string firstname, string surname)
        {
            Number = number;
            Firstname = firstname;
            Surname = surname;
        }

        public override string ToString()
        {
            string s = Number + ", " + Firstname + ", " + Surname;
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("123", "John", "Doe");
            students[1] = new Student("777", "Jane", "Doe");
            students[2] = new Student("321", "Tommy", "Atkins");
            students[3] = new Student("971", "Karl", "Marx");
            students[4] = new Student("414", "Rosa", "Luxemburg");


            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(students[i].ToString());
            }
        }
    }
}
