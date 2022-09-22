using System;
namespace Homework3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            double D;
            Console.WriteLine("Enter values for a, b and c to calculate" +
                " the quadratic equation.");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            D = b*b-4*a*c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"There are two real soulutions:\nx1 = {x1} \nx2 = {x2}");
            }
            else if (D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"There is one real solution:\nx = {x1}");
            }
            else
            {
                Console.WriteLine("The function has no real roots," +
                    " there are two complex solutions");
            }
            Console.ReadKey();
        }
    }
}
