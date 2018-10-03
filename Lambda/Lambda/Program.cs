using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Bales", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 2 };
            Employee employee3 = new Employee() { FirstName = "Bob", LastName = "Bales", ID = 3 };
            Employee employee4 = new Employee() { FirstName = "Bob", LastName = "Smith", ID = 4 };
            Employee employee5 = new Employee() { FirstName = "James", LastName = "Bond", ID = 5 };
            Employee employee6 = new Employee() { FirstName = "Chuck", LastName = "Testa", ID = 6 };
            Employee employee7 = new Employee() { FirstName = "Will", LastName = "Smith", ID = 7 };
            Employee employee8 = new Employee() { FirstName = "Ted", LastName = "Nugent", ID = 8 };
            Employee employee9 = new Employee() { FirstName = "Bigger", LastName = "Boot", ID = 9 };
            Employee employee10 = new Employee() { FirstName = "Ben", LastName = "Franklin", ID = 10 };
            List<Employee> employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };

            //Display full list
            Console.WriteLine("Dream Team:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            //create Joe list
            List<Employee> guysNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    guysNamedJoe.Add(employee);
                }
            }

            //display joe list
            Console.WriteLine("Guys Named Joe:");
            foreach (Employee guy in guysNamedJoe)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

            //create Joe list 2
            List<Employee> guysNamedJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();

            //display joe list 2
            Console.WriteLine("Guys Named Joe from lambda:");
            foreach (Employee guy in guysNamedJoe2)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName + " ID:" + guy.ID);
            }
            Console.WriteLine();

            //create ID5 List
            List<Employee> ID5 = employees.Where(x => x.ID > 5).ToList();

            //display ID5 List
            Console.WriteLine("Employees with ID > 5:");
            foreach (Employee employee in ID5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID:" + employee.ID);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
