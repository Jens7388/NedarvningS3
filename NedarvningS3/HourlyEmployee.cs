
namespace NedarvningS3
{
    class HourlyEmployee : Employee
    {
        protected double wage;
        protected double hours;

        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double wage, double hours) : base(
            firstName, lastName, socialSecurityNumber)
        {
            Wage = wage;
            Hours = hours;
        }

        public virtual double Wage
        {
            get
            {
                return wage;
            }

            set
            {
                wage = value;
            }
        }

        public virtual double Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }
    }
}