using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"D:/K2480/teksti1.txt");
                while (true)
                {
                    Console.WriteLine("Enter text: ");
                    var text = Console.ReadLine();
                    if (text.Equals("exit", StringComparison.OrdinalIgnoreCase))
                        break;
                    outputFile.WriteLine(text);
                }
                outputFile.Close();
            }
            catch(FormatException)
            {
                Console.WriteLine("Your input wasn't valid!");
            }
            catch(Exception)
            {
                Console.WriteLine("Some error occured.");
            }
        }
    }
}
