using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    public class Dice
    {
        public int Pip { get; set; }

    }
    class Program
    {
        static int throwDice()
        {
            Random rand = new Random();
            int diceThrow = rand.Next(1, 7);
            return diceThrow;
        }
        static void addPip()
        {
            throwDice();

        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int temp = 0;
            int total = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int throwCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < throwCount; i++)
            {
                int diceThrow = rand.Next(1, 7);
                temp = total + diceThrow;
                total = temp;
                if (diceThrow == 1)
                    num1++;
                if (diceThrow == 2)
                    num2++;
                if (diceThrow == 3)
                    num3++;
                if (diceThrow == 4)
                    num4++;
                if (diceThrow == 5)
                    num5++;
                if (diceThrow == 6)
                    num6++;
            }
            int average = total / throwCount;
            Console.WriteLine("The average of the throws was: " + average);
            Console.WriteLine("Amount of 1s: " + num1);
            Console.WriteLine("Amount of 2s: " + num2);
            Console.WriteLine("Amount of 3s: " + num3);
            Console.WriteLine("Amount of 4s: " + num4);
            Console.WriteLine("Amount of 5s: " + num5);
            Console.WriteLine("Amount of 6s: " + num6);
        }
    }
}
