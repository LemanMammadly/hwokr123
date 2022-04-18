using HWork.Models;
using System;

namespace HWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("KLkad HBjnsd");
            Employee employee2 = new Employee("GFhgas jknsd");
            Employee employee3 = new Employee("Hghjbd BJHbsj");
            Company company = new Company() { Name = "Hello", Limit = 3 };
            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            company.AddEmployee(employee3);


            foreach (Employee item in company.GetEmployees())
            {
                Console.WriteLine($"Ad Soyad: {item.FullName} No: {item.No}");
            }

        }
    }
}
