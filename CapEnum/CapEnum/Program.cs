using System;
using CapEnum.Entities;
using CapEnum.Entities.Enum;
namespace CapEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderEnum.Processing
            };
            Console.WriteLine(order);
        
            

           


        }
    }
}
