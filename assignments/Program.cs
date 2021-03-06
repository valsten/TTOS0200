﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{

    class Window
    {
        // Properties
        public float Width { get; set; }
        public float Height { get; set; }
        public float Area
        {
            get { return Width * Height; }
        }
        public float Perimeter
        {
            get { return 2 * (Width + Height); }
        }
        // Constructors
        public Window()
        {
            // Default Constructor
        }
        public Window (float width, float height)
        {
            Height = height;
            Width = width;
        }

        // Methods
        public float CalculateArea()
        {
            return Width * Height;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OOWindowDemo();
        }

        static void OOWindowDemo()
        {
            float Width = 0;
            float Height = 0;
            float Area, Perimeter = 0;

            Console.WriteLine("Input the width of the window: ");
            Width = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the height of the window: ");
            Height = float.Parse(Console.ReadLine());

            Area = Width * Height;
            Perimeter = 2 * (Width + Height);
            Console.WriteLine("The area of the window is {0} and the perimeter is {1} \n", Area, Perimeter);

            Window window = new Window();
            window.Width = Width;
            window.Height = Height;

            // Area = window.CalculateArea();
            Console.WriteLine("Object Oriented:");
            Console.WriteLine("The area of the window is {0} and the perimeter is {1} \n", window.Area, window.Perimeter);

            // Testing 2nd Constructor with a smaller window
            Window window2 = new Window(Width / 2, Height / 2);
            Console.WriteLine("Constructor 2:");
            Console.WriteLine("The area of the window is {0} and the perimeter is {1}", window2.Area, window2.Perimeter);
        }
    }
}
