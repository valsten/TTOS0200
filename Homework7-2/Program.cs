using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"D:/K2480/teksti2.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }

                var lineCount = File.ReadLines(@"D:/K2480/teksti2.txt").Count();
                var uniqueLines = File.ReadAllLines(@"D:/K2480/teksti2.txt").Distinct().Count();
                Console.WriteLine("Found {0} lines with {1} names.", lineCount, uniqueLines);

                using (StreamWriter sw = new StreamWriter(@"D:/K2480/temp/teksti2.txt"))
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
