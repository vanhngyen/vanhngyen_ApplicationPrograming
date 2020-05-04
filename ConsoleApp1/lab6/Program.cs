using System;

namespace ConsoleApp1.lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("----------------- Calculator ----------------");
                Console.WriteLine("1 . add ");
                Console.WriteLine("2 . sub ");
                Console.WriteLine("3 . div ");
                Console.WriteLine("4 . mul ");
                Console.WriteLine("Enter : ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter a :");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b :");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Calculator.Add(a, b);
                        
                        break;
                    case 2:
                        Console.WriteLine("Enter a :");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b :");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Calculator.Sub(c, d);
                        break;
                    case 3:
                        Console.WriteLine("Enter a :");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b :");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Calculator.div(e, f);
                        break;
                    case 4:
                        Console.WriteLine("Enter a :");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter b :");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Calculator.Mul(g, h);
                        break;
                    default:
                        Console.WriteLine("the end !");
                        break;
                }
            }
        }
    }
}