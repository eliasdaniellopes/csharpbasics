using System;
using System.Globalization;
using System.Text;

namespace ExerciseInheritancePolimorfism.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Name} $ { totalPrice().ToString("F2", CultureInfo.InvariantCulture)}  Customs fee : {CustomsFee}");
            return sb.ToString();
        }

    }
}
