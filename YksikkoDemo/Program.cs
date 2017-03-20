using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoDemo
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);
        int Subtract(int number1, int number2);
        int Divide(int number1, int number2);
    }
    public class Calculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator marx = new Calculator();
            int result1 = marx.Add(10, 20);
            int result2 = marx.Multiply(5, 5);

            Console.WriteLine("10 + 20 = " + result1);
            Console.WriteLine("5 * 5 = " + result2);
            
        }
    }
}
