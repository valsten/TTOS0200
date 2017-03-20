using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    class Elevator
    {
        private readonly int MaxFloor = 5;
        private readonly int MinFloor = 1;

        private int floor = 1;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if ((value <= MaxFloor) && (value >= MinFloor))
                {
                    floor = value;
                }
                else
                {
                    Console.WriteLine("There is no such floor!");
                    floor = 1;
                }
            }
        }
        public void CurrentFloor()
        {
            Console.WriteLine("You are on floor " + Floor);
        }
        public void ChangeFloor()
        {
            Console.WriteLine("Which floor do you want to go to? ");
            string temp = Console.ReadLine();
            int temp2 = int.Parse(temp);
            Floor = temp2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            elevator.Floor = 1;

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Please enter the number that you want to do:");
                Console.WriteLine("1. Change Floor");
                Console.WriteLine("2. Current Floor");
                Console.WriteLine("0. Exit");

                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        elevator.ChangeFloor();
                        break;
                    case 2:
                        elevator.CurrentFloor();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
            

        }
    }
