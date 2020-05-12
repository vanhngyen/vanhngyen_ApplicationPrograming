using System;

namespace ConsoleApp1.practical.geometryExample
{
    public class Result
    {
        
        public static void Main(string[] args)
        {
            double radius = 0;
            double height = 0;
            Console.WriteLine("------- calculate -------");
            Console.WriteLine("Enter Radius :");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height :");
            height = Convert.ToDouble(Console.ReadLine());
            process pp = new process(radius,height);
            Console.WriteLine("Base :"+pp.getBaseArea());
            Console.WriteLine("Lateral :"+pp.getLateralArea());
            Console.WriteLine("Total :"+pp.getTotalArea());
            Console.WriteLine("Volume :"+pp.getVolume());
            
        }

    }
}