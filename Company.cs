using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        //Constructor Method for creating new instance of Company
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        //Add Employee Constructor for Company class
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        //List Employee Constructor for Company class
        public void ListEmployees()
        {
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as a {employee.Title} since {employee.StartDate}");
            }

        }

    }
}
