using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_2
{
    class Amplifier
    {
        private readonly int MaxVolume = 100;
        private readonly int MinVolume = 0;

        private int volume = 0;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if ((value <= MaxVolume) && (value >= MinVolume))
                {
                    volume = value;
                }
                else if (value < MinVolume)
                {
                    Console.WriteLine("Too low volume, automatically set to 0.");
                    volume = 0;
                }
                else if (value > MaxVolume)
                {
                    Console.WriteLine("Too high volume, automatically set to 100.");
                    volume = 100;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
        }
        public void PrintVolume()
        {
            Console.WriteLine("Volume now set to {0}", Volume);
        }
        public void ChangeVolume()
        {
            string temp = Console.ReadLine();
            int temp2 = int.Parse(temp);
            Volume = temp2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Homework4_2.Amplifier();
            while(true)
            {
                Console.WriteLine("Give a new volume value (0-100): ");
                amplifier.ChangeVolume();
                amplifier.PrintVolume();
            }
        }
    }
}
