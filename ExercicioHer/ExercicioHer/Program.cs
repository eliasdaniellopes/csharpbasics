using System;
using ExercicioHer.Entities;
using System.Collections.Generic;
namespace ExercicioHer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> list = new List<Employee>();
            
            Console.WriteLine("Numero de empregados");
            int nEmployee = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < nEmployee; i++)
            {
                Console.WriteLine("É externo? s/n");
                char ext = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Horas");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora");
                double valuePerHour = double.Parse(Console.ReadLine());
                
                if (ext == 's')
                {
                    Console.WriteLine("Gastos com despesas");
                    double desp = double.Parse(Console.ReadLine());

                    list.Add(new OutsourceEmployee
                    {
                        Name = name,
                        Hours = hours,
                        ValuePerHour = valuePerHour,
                        AdditionalCharge = desp
                    });
                    
                    
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                
            }
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
