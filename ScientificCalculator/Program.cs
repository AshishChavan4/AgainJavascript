using System;

namespace ScientificCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Server=localhost;Database=PremadeTask;User ID=root;Password=1234;";


            Calculator calc = new Calculator();


            double sinResult = calc.Sin(Math.PI / 2);
            double logResult = calc.Log(100);
            double expResult = calc.Exp(2);
            double powerResult = calc.Power(2, 3);


            calc.LogCalculation($"Sin(π/2) = {sinResult}", connectionString);
            calc.LogCalculation($"Log(100) = {logResult}", connectionString);
            calc.LogCalculation($"Exp(2) = {expResult}", connectionString);
            calc.LogCalculation($"Power(2, 3) = {powerResult}", connectionString);


            Console.WriteLine($"Sin(π/2) = {sinResult}");
            Console.WriteLine($"Log(100) = {logResult}");
            Console.WriteLine($"Exp(2) = {expResult}");
            Console.WriteLine($"Power(2, 3) = {powerResult}");

            Console.WriteLine("Calculations logged successfully.");
        }
    }
}
