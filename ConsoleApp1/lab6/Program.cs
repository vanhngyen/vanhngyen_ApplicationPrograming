using System;

namespace ConsoleApp1.lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {    
            
            int choose;
            
            while (true)
            {
                Show();
                choose = ReadNumber();
                Console.WriteLine("Enter a :");
                int a = ReadNumber();
                Console.WriteLine("Enter b :");
                int b = ReadNumber();
                Cclt cc = Calculator.getCalc(choose);
                switch (choose)
                {
                    case 1:
                        cc(a, b);
                        break;
                    case 2:
                        cc(a, b);
                        break;
                    case 3:
                        cc(a, b);
                        break;
                    case 4:
                        cc(a, b);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void Show()
        {
            Console.WriteLine("----------------- Calculator ----------------");
            Console.WriteLine("1 . add ");
            Console.WriteLine("2 . sub ");
            Console.WriteLine("3 . div ");
            Console.WriteLine("4 . mul ");
            Console.WriteLine("Enter : ");
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}