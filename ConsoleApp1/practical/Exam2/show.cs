using System;

namespace ConsoleApp1.practical.Exam2
{
    public class show
    {
        public static void Main(string[] args)
        {
            animal.tiger a = new animal.tiger("tiger",100);
            animal.lion b = new animal.lion("lion",200);
            Console.WriteLine("---- animal ----");
            Console.WriteLine("Name = {0}", a.Name);
            Console.WriteLine("Weight = {0}", a.Weight);
            Console.WriteLine("Name = {0}", b.Name);
            Console.WriteLine("Weight = {0}", b.Weight);
            
        }
    }
}