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
            Teht10();
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

        static void Teht3()
        {
            /*
             * Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja 
             * tulostaa niiden summan ja keskiarvon.
             */

            Console.Write("Write three numbers and I'll print out their sum and average. \n");

            Console.Write("First number: ");
            string tempnumber = Console.ReadLine();
            int num1 = int.Parse(tempnumber);
            Console.Write("Second number: ");
            tempnumber = Console.ReadLine();
            int num2 = int.Parse(tempnumber);
            Console.Write("Third number: ");
            tempnumber = Console.ReadLine();
            int num3 = int.Parse(tempnumber);

            Console.Write("Sum: " + (num1 + num2 + num3) + "\n");
            Console.Write("Average: " + (num1 + num2 + num3) / 3 + "\n");
        }

        static void Teht4()
        {
            /*
             * Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
             * Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
             * jos se on 18-65 vuotta, tulosta "aikuinen", 
             * muussa tapauksessa tulosta "seniori".
             */

            Console.Write("Input your age: ");

            string tempnumber = Console.ReadLine();
            int age = int.Parse(tempnumber);

            if (age < 18)
                Console.Write("Minor \n");

            else if (age >= 18 && age <= 65)
                Console.Write("Adult \n");

            else
                Console.Write("Senior \n");
        }

        static void Teht5()
        {
            /*
             * Tee ohjelma, joka näyttää annetun sekuntimäärän 
             * tunteina, minuutteina ja sekunteina. Aikamääre 
             * sekuntteina kysytään käyttäjältä.
             */

            Console.Write("Input seconds: ");

            string temp = Console.ReadLine();
            int seconds = int.Parse(temp);

            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string str = time.ToString(@"hh\:mm\:ss\:fff");

            Console.Write(str + "\n");
        }

        static void Teht6()
        {
            /*
             * Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja 
             * bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa 
             * ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan 
             * määrän sekä bensaan menevän rahan määrän.
             */

            double consumption = 7.02;
            double price = 1.595;

            Console.Write("Input travel distance: ");

            string temp = Console.ReadLine();
            double distance = int.Parse(temp);

            double gasoline = distance / 100 * consumption;
            double cost = gasoline * price;

            Console.WriteLine("Gas Consumption: " + gasoline + "\n");
            Console.WriteLine("Cost is " + cost + "€");
        }

        static void Teht7()
        {
            /*
             * Tee ohjelma, joka näyttää onko annettu vuosi 
             * karkausvuosi. Vuosiluku kysytään käyttäjältä.
             */

            Console.Write("Check if inputted year is a leap year: ");

            string temp = Console.ReadLine();
            int year = int.Parse(temp);

            if (DateTime.IsLeapYear(year))
                Console.Write(year + " is a leap year \n");

            else
                Console.Write(year + " is not a leap year \n");
        }

        static void Teht8()
        {
            /*
             * Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua
             * ja tulostaa niistä suurimman.
             */

            Console.Write("First number: ");
            string tempnumber = Console.ReadLine();
            int num1 = int.Parse(tempnumber);

            Console.Write("Second number: ");
            tempnumber = Console.ReadLine();
            int num2 = int.Parse(tempnumber);

            Console.Write("Third number: ");
            tempnumber = Console.ReadLine();
            int num3 = int.Parse(tempnumber);

            Console.WriteLine(Math.Max(Math.Max(num1, num2), num3));
        }

        static void Teht9()
        {
            /*
             * Tee ohjelma, joka kysyy käyttäjältä lukuja, 
             * kunnes hän syöttää luvun 0. Ohjelman tulee 
             * tulostaa syötettyjen lukujen summa.
             */

            //int number;
            int number;
            int sum = 0;
            bool check = true;

            do
            {
                Console.Write("Input a number: ");
                string tempnumber = Console.ReadLine();
                number = int.Parse(tempnumber);
                if (check)
                    sum += number;
            }
            while (check && number != 0);
            Console.WriteLine("The sum of the numbers is: " + sum + "\n");
           
        }

        static void Teht10()
        {
            /* Tee ohjelma, joka alustaa sovellukseen käyttöö 
             * seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
             * Käy sovelluksessa taulukko läpi ja tulosta ruutuun 
             * "HEP"-sana aina kun taulukossa oleva luku on parillinen.
             */

            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < 8; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " HEP! \n");
                }
            }
        }
    }
}
