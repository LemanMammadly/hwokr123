using System;
using System.Collections.Generic;
using System.Text;

namespace HWork.Models
{
    internal class Employee
    {
        public static int Id = 1;
        public string No;
        public string FullName;
        public int Salary;
        public string Position;

        public Employee(string fullName)
        {
            FullName = fullName;
            No = $"{FullName[0]}{Id}";
            Id++;
            
        }
    }
}
