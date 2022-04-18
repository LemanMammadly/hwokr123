using System;
using System.Collections.Generic;
using System.Text;

namespace HWork.Models
{
    internal class Company
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                char ch = value[0];

                foreach (char item in value)
                {
                    if (char.IsLower(ch) && char.IsSymbol(item))
                    {
                        Console.WriteLine("Duzgun daxil edin..");
                    }
                    else
                    {
                        _name = value;
                    }
                }
            }
        }
        public int Limit;
        public Employee[] Employees;
        public Company()
        {
            Employees= new Employee[0];
            
        }
        
        public void AddEmployee(Employee employee) 
        {
            if (Employees.Length<Limit)
            {
                Array.Resize(ref Employees, Employees.Length+1);
                Employees[Employees.Length-1] = employee;
                return;
            }
            else
            {
                Console.WriteLine("Yer yoxdu");
            }
        }

        public Employee[] GetEmployees()
        {
            return Employees;
        }

    }
}
