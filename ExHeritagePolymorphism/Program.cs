using System;
using System.Collections.Generic;
using System.Globalization;
using ExHeritagePolymorphism.Entities;

namespace ExHeritagePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of produtcs: ");
            int numProducts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Comun, used or imported (c/u/i)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (answer == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
