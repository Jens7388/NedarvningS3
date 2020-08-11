
namespace NedarvningS3
{
    class SalariedEmployee : Employee
    {
        protected double weeklySalary;

        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, double weeklySalary):
            base (firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public virtual double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }

            set
            {
                weeklySalary = value;
            }
        }
    }
}