using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTest1
{
    class Manager:Employee
    {
        public double Bonus { get; set; }
        public Manager(int Id, string name, double basicSalary, double bonus):base(Id, name, basicSalary ) { 
            Bonus = bonus;
        }
        public override double CalculateSalary()
        {
            return Bonus+base.CalculateSalary();
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Manager Info");
            base.DisplayDetails();
            Console.WriteLine($"  Bonus: {Bonus}\n  Total Salary: {CalculateSalary()}");
        }
    }
}
