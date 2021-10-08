

using System;

namespace MyOrganisationLibrary.Model
{
    public class Employee
    {
        public const string Country = "India";

        private string name;
        public Guid Id { get; }

        // readonly vs constant
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != null && name != value)
                {
                    if (Isvalid(value))
                    {
                        name = value;
                    }
                }
            }
        }

        private bool Isvalid(string value)
        {
            if (value == "Ashu")
            {
                return true;
            }

            return false;
        }

        public string Address { get; set; }

        public Department Opco { get; }

        public Employee(string fullName, string opcoName)
        {
            Id = Guid.NewGuid();
            name = fullName;
            Opco = new Department(opcoName, 132);
        }

        public void SetName(string n)
        {
            //name = n;
        }
    }
}
