using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) 
 * vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää 
 * jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
 */

namespace TTOS0200
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht1();
        }

        static void Teht1()
        {
            Console.Write("Write a number (1, 2 or 3): ");

            string tempnumber = Console.ReadLine();
            int number = int.Parse(tempnumber);

            if (number == 1)
                Console.Write("One \n");

            else if (number == 2)
                Console.Write("Two \n");

            else if (number == 3)
                Console.Write("Three \n");

            else
                Console.Write("The number you input was not within the range \n");
        }
    }
}
