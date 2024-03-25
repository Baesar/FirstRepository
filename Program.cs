namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson()
            {
                Age = 31, Name = "Fred", SalesNumber = 50
            };

            Console.WriteLine("This is a change");
            
        }
    }
}
