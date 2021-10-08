using System;
using System.Collections.Generic;

namespace MyOrganisationLibrary.Model
{
    public class Company
    {
        public List<Employee> Employees { get; set; }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(string name, string opco)
        {
            Employees.Add(new Employee(name, opco));
        }

        public void RemoveEmployee(Guid guid)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == guid)
                {
                    Employees.Remove(Employees[i]);
                    break;
                }
            }
        }
    }
}
