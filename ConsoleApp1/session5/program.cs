using System;

namespace ConsoleApp1.session5
{
    public class program
    {
        public static int ProgramCode;
    }

    namespace MyNamespace
    {
        public class MyClass
        {
            public void ShowInfo()
            {
                try
                {
                    int x = 10;
                    int y = 0;
                    Console.WriteLine(x/y);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); //message để lấy giá trị
                }
                Console.WriteLine("done");
            }
        }
    }
}

//tao doi tuong program cua namespace ConsoleApp1.session5 -> biet tao lop nao
namespace ConsoleApp1.session5.Demo
{
    public class Program
    {
        
    }

    public class DemoProgram
    {
        
    }
}