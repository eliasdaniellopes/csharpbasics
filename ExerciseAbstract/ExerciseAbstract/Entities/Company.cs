using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseAbstract.Entities
{
    class Company : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double annualIncome, int numberEmployees)
            : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }
        public override double Tax()
        {
            double tax;
            if (NumberEmployees > 10)
            {
                return AnnualIncome * 0.14;

            }
            else
            {
                return AnnualIncome * 0.16;
            }

        }
    }
}
