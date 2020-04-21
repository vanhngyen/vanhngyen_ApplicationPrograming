using System;

namespace ConsoleApp1.session3
{
    public class Woman:Human
    {
        public override void Running()
        {
            Console.WriteLine("Run and single !");
        }

        public new void eat()
        {
            Console.WriteLine("eat and single !");
        }
    }
}