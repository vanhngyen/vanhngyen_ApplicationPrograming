using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                if (fibonacci(i) < n)
                    Console.WriteLine(n + " -> " + fibonacci(i));
                   
            }
        }

        static int fibonacci(int a)
        {
            if (a < 0)
            {
                return a;
            }
            if (a == 0 || a == 1)
            {
                return a;
            }

            return fibonacci(a - 1) + fibonacci(a - 2);
        }
    }
}