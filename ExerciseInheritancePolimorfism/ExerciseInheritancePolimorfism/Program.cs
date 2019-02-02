using ExerciseInheritancePolimorfism.Entities;
using System;
using System.Collections.Generic;

namespace ExerciseInheritancePolimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Entre com o número de produtos");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("O produto é Comum, Usado ou Importado?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome do produto");
                string name = Console.ReadLine();
                Console.WriteLine("Preço do produto");
                double price = double.Parse(Console.ReadLine());
                if(ch == 'i')
                {
                    Console.WriteLine("Taxa");
                    double tax = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, tax));

                }
                else if(ch == 'u')
                {
                    Console.WriteLine("Data de fabricação");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("PRICE TABS");
            foreach (Product x in list)
            {
                Console.WriteLine(x.priceTag());
            }
        }
    }
}
