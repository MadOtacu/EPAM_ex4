using System;

namespace EPAM_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(--x);
            }
        }
    }
}
