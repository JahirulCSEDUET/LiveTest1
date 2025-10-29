using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTest1
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public double BasicSalary { get; set; }
        public Employee(int Id, string name, double basicSalary) {
            EmployeeId = Id;
            Name = name;
            BasicSalary = basicSalary;
        }   
        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}\n  EmployeeId: {EmployeeId}\n  BasicSalary: {BasicSalary}");
        }
    }
}
