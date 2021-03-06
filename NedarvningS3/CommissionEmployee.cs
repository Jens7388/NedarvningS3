﻿
using System;

namespace NedarvningS3
{
    class CommissionEmployee : Employee
    {
        //indtægt alene baseret på salg
        protected double grossSales;
        protected double commissionRate;

        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, double grossSales, double commissionRate)
            :base(firstName, lastName, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public virtual double GrossSales
        {
            get
            {
                return grossSales;
            }

            set
            {
                grossSales = value;
            }
        }

        public virtual double CommissionRate
        {
            get
            {
                return commissionRate;
            }

            set
            {
                commissionRate = value;
            }
        }
        public override double GetPaymentAmount()
        {
            return grossSales * commissionRate;
        }
    }
}