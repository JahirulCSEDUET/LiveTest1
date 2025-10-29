namespace LiveTest1
{
    class Developer:Employee
    {
        public double ProjectAllowance {  get; set; }
        public Developer(int Id, string name, double basicSalary, double projectAllowance):base(Id, name,basicSalary) {
            ProjectAllowance = projectAllowance;
        }
        public override double CalculateSalary()
        {
            return ProjectAllowance + base.CalculateSalary();
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Developer info");
            base.DisplayDetails();
            Console.WriteLine($"  Project Allowance: {ProjectAllowance}\n  Total Salary: {CalculateSalary()}");
        }
    }
}
