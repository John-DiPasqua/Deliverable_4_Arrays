using System;

namespace Deliverable_4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define array with first two elements
            int[] fib = new int[] { 0, 1 };


            int user_length = 25;

            while (fib.Length < user_length)
            {
                int next = fib[fib.Length - 1] + fib[fib.Length - 2];
                fib = fib.Append(next).ToArray();
            }

            for (int i = 0; i < fib.Length; i++)
            {
                Console.WriteLine($"Fibonacci number ({i}) = {fib[i]}");
            }
        }
    }
}