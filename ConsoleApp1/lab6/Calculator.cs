using System;

namespace ConsoleApp1.lab6
{
    public delegate int Cclt(int a, int b);
    public class Calculator
    {
        public static int Add(int a, int b)
        {
           
            Console.WriteLine(a+" + "+b+" = "+(a+b));
            return a + b;
        }
        
        public static int Sub(int a, int b)
        {
            
            Console.WriteLine(a+" - "+b+" = "+ (a-b));
            return a - b;
        }
        
        public static int div(int a, int b)
        {
            
            Console.WriteLine(a+" / "+b+" = "+(a/b));
            return a / b;
        }
        
        public static int Mul(int a, int b)
        {
           
            Console.WriteLine(a +" * "+b+" = "+(a*b));
            return a * b;
        }
        
    }
}