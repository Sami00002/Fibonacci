using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }

        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
