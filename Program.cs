namespace LiveTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "Jahir", 2387.5, 673.8);
            Developer developer = new Developer(2, "Islam", 37824, 582);
            manager.DisplayDetails();
            developer.DisplayDetails();
        }
    }
}
