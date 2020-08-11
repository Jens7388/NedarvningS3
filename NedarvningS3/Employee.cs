using System;

namespace NedarvningS3
{
    abstract class Employee: Payable
    {
        protected string firstName;
        protected string lastName;
        protected string socialSecurityNumber;

        protected Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public virtual string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public virtual string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public virtual string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }

            set
            {
                socialSecurityNumber = value;
            }
        }

        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}