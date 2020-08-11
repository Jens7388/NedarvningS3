
namespace NedarvningS3
{
    class BasePlusCommissionEmployee: CommissionEmployee
    {
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
    }
}