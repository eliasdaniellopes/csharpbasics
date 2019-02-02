using System;
using System.Globalization;
using System.Text;

namespace ExerciseInheritancePolimorfism.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            :base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Name} (used) $ { Price.ToString("F2", CultureInfo.InvariantCulture)}  (Manufacture date : {ManufactureDate})");
            return sb.ToString();
        }
    }
}
