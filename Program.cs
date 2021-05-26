using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company seeCompany = new Company("See Company", new DateTime(1995, 03, 05));

            // Create three employees
            Employee EMP1 = new Employee()
            {
                FirstName = "Leroy",
                LastName = "Peabody",
                Title = "Banana Peeler",
                StartDate = new DateTime(2013, 5, 5)
            };
            Employee EMP2 = new Employee()
            {
                FirstName = "Jerry",
                LastName = "Kelly",
                Title = "Guitar Smelter",
                StartDate = new DateTime(2003, 11, 23)
            };
            Employee EMP3 = new Employee()
            {
                FirstName = "Preston",
                LastName = "Brewer",
                Title = "Coke Sniffer",
                StartDate = new DateTime(2003, 11, 27)
            };


            // Assign the employees to the company

            seeCompany.AddEmployee(EMP1);
            seeCompany.AddEmployee(EMP2);
            seeCompany.AddEmployee(EMP3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            seeCompany.ListEmployees();

        }
    }
}
