using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groceries
{
    public class Cart
    {
        public void PrintContents(List<string> list )
        {
            list.ForEach(Console.WriteLine);
        }
    }
    
    public class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public double Cost { get; set; }

        public override string ToString()
        {
            string s = Name + ", " + Cost + "e";
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new groceries.Cart();

            List<string> list = new List<string>();

            Product milk = new groceries.Product("Maito", 1.5);
            Product mango = new groceries.Product("Mango", 0.5);
            Product noodle = new groceries.Product("Nuudeli", 1.0);
            Product soap = new groceries.Product("Saippua", 3.5);
            Product ham = new groceries.Product("Kinkku", 2.1);

            list.Add(milk.ToString());
            list.Add(mango.ToString());
            list.Add(soap.ToString());
            list.Add(noodle.ToString());
            list.Add(ham.ToString());

            cart.PrintContents(list);

        }
    }
}
