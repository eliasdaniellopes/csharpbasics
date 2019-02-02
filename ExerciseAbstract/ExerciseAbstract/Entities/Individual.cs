using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseAbstract.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double annualIncome, double healthExpenses)
          : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {


            if (AnnualIncome < 2000.00)
            {
                return AnnualIncome * 0.15 - HealthExpenses * 0.50;

            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenses * 0.50;


            }



        }
    }
}
