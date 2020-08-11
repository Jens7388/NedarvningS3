using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NedarvningS3
{
    class BaseCommissionEmployee : CommissionEmployee
    {
        protected double baseSalary;

        public BaseCommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate,
            double baseSalary) : base (firstName, lastName, socialSecurityNumber, grossSales, commissionRate)
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
    }