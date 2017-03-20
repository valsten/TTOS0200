using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Varmista onko tekstitiedostot jo olemassa, ja jos ovat niin poistaa ne.
            bool checkint = File.Exists(@"D:/K2480/teksti3int.txt");
            if (checkint == true)
            {
                File.Delete(@"D:/K2480/teksti3int.txt");
            }

            bool checkbool = File.Exists(@"D:/K2480/teksti3double.txt");
            if (checkbool == true)
            {
                File.Delete(@"D:/K2480/teksti3double.txt");
            }


            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals(" ", StringComparison.OrdinalIgnoreCase))
                    break;
                else if (input.IndexOf(".") <= 0) // Katsoo onko syotteessa pistetta. Jos ei, kirjoittaa sen 'int' tiedostoon.
                {
                    using (StreamWriter sw = new StreamWriter(@"D:/K2480/teksti3int.txt", true))
                    {
                        sw.WriteLine(input);    
                    }
                }

                else if (input.IndexOf(".") >= 0) // Katsoo onko syotteessa pistetta. Jos on, kirjoittaa sen 'double' tiedostoon.
                {
                    using (StreamWriter sw = new StreamWriter(@"D:/K2480/teksti3double.txt", true))
                    {
                        sw.WriteLine(input);
                    }
                }
                }
            }
        }
    }
