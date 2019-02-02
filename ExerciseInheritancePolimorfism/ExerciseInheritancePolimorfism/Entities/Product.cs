using System;
using System.Globalization;
using System.Text;

namespace ExerciseInheritancePolimorfism.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String priceTag()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append($"{Name} $ {Price} ");
            return sb.ToString();
        }
    }
}
