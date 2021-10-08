using System;
using System.Linq;
using MyOrganisationLibrary.Model;


namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var istrue = false;

            var compnay = new Company();
            compnay.AddEmployee("Anoop", "Hach");

            var employeeInstance = compnay.Employees.FirstOrDefault(s => s.Name == "Anoop");
            employeeInstance.Address = "banaglore";

            Console.WriteLine($"{employeeInstance.Id}-{employeeInstance.Name}-{employeeInstance.Opco.Name}");
            Console.ReadLine();

            // Opps

            // Abstraction - 
            // Encapsulation - 
            // Inheritence 


            // Access Modifier

            // Public - can be accessed public, any component can access
            // private - can be accessed with in a class
            // protected - can be accesses with in a class also on child/ derived classes
            // internal - can be accesses with in assembly. 
        }
    }
}
