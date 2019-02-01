using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioComp.Entities.Enums;
using System.Text;
namespace ExercicioComp.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> list { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Product Product{ get; set; }


        public Order()
        {

        }

        public Order(Client client)
        {
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            list.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            list.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem x in list)
            {
                total += x.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine("Infomrações do Pedido");
            sb.AppendLine("Hora  do pedido: " + Date.ToString("dd/MM/yyyy"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("-----------------------------------------------");
            sb.AppendLine("Informações do cliente: ");
            sb.AppendLine("Cliente: " + Client.Name + $"({Client.BirthDate.ToString("dd-MM-yyyy")})");
           
            sb.AppendLine("Email:" + Client.Email);
            sb.AppendLine("Itens do Pedido: ");
            foreach(OrderItem x in list)
            {
                sb.AppendLine("Produto: " + x.Product.Name);
                sb.AppendLine("Quantidade: " + x.Quantity.ToString());
                sb.AppendLine("Subtotal: " + x.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

                
        }
    }
}
