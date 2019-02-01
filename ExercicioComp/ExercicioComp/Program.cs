using System;
using System.Globalization;
using ExercicioComp.Entities.Enums;

using ExercicioComp.Entities;
namespace ExercicioComp
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome");
            string clientName = Console.ReadLine();
            Console.WriteLine("email");
            string email = Console.ReadLine();
            Console.WriteLine("Data de aniversario");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());


            Console.WriteLine($"Digite o status");
            string statusOrder = Console.ReadLine();
            Console.WriteLine("Quantos produtos deseja comprar?");
            int n = int.Parse(Console.ReadLine());
            Order order = new Order();
            for (int i = 0; i < n; i++)
            {
               

                Console.WriteLine($"Digite o item {i + 1}");
                string name = Console.ReadLine();
                Console.WriteLine($"Digite o preço {i + 1}");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Digite o quantidade {i + 1}");
                int quantity = int.Parse(Console.ReadLine());

                order.Status = Enum.Parse<OrderStatus>(statusOrder);
                order.Date = DateTime.Now;
                Product product = new Product
                {
                    Name = name,
                    Price = price
                };
                order.addItem(new OrderItem
                {
                    Price = price,
                    Quantity = quantity,
                    Product = product
                    
                });

                
            }
            order.Client = new Client
            {
                Name = clientName,
                BirthDate = birthDay,
                Email = email,

            };


            Console.WriteLine(order);

        }
    }
}
