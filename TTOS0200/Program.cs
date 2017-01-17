using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTOS0200
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht2();
        }

        static void Teht1()
        {

            /*
            * Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) 
            * vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää 
            * jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
            */

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

        static void Teht2()
        {
            /*
             * Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan 
             * taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
             */ 

            Console.Write("Input your score and I'll tell you your grade: ");

            string tempscore = Console.ReadLine();
            int score = int.Parse(tempscore);

            if (score == 0 || score == 1)
                Console.Write("Your grade is F \n");

            else if (score == 2 || score == 3)
                Console.Write("Your grade is E \n");

            else if (score == 4 || score == 5)
                Console.Write("Your grade is D \n");

            else if (score == 6 || score == 7)
                Console.Write("Your grade is C \n");

            else if (score == 8 || score == 9)
                Console.Write("Your grade is B \n");

            else if (score >= 10 && score <= 12)
                Console.Write("Your grade is A \n");

            else
                Console.Write("Your score is not in the range \n");
        }
    }
}
