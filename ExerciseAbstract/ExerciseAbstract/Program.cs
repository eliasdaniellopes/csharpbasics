using System;
using System.Globalization;
using System.Collections.Generic;
using ExerciseAbstract.Entities;
using System.Text;
namespace ExerciseAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de contribuintes");
            int n = int.Parse(Console.ReadLine());
            List<Taxpayer> list = new List<Taxpayer>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pessoa física ou Jurídica? f/j");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Renda Anual");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'j')
                {
                    Console.WriteLine("Numero de empregados");
                    int nEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, nEmployees));
                }
                else if (ch == 'f')
                {
                    Console.WriteLine("Gastos com saúde");
                    double heathExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, heathExpenses));
                }
            }
            Console.WriteLine("TAXAS PAGAS: ");
            double total = 0;
            foreach (Taxpayer x in list)
            {
                total += x.Tax();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{x.Name}: $ {x.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine($" TOTAL TAXES: $ {total}");
        }
    }
}
