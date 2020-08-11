
using System;

namespace NedarvningS3
{
    class BasePlusCommissionEmployee: CommissionEmployee
    {
        //indtægt baseret på fast løn + salg    
        protected double baseSalary;

        public BasePlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate,
            double baseSalary) : base(firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public virtual double BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                baseSalary = value;
            }
        }
        public override double GetPaymentAmount()
        {
            return grossSales * commissionRate + baseSalary;
        }
    }
}