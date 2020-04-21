using System;

namespace ConsoleApp1.Product2
{
    public class Diamon:Product2
    {
        protected double cara;

        public Diamon()
        {
        }

        public Diamon(double cara)
        {
            this.cara = cara;
        }

        public Diamon(int id, string name, int price, int qty, string image, string desc, double cara) : base(id, name, price, qty, image, desc)
        {
            this.cara = cara;
        }

        public void checkSoFake()
        {
            if (cara > 10)
            {
                Console.WriteLine("genuine goods .");
            }
            else
            {
                Console.WriteLine("Counterfeiting !");
            }
        }
    }
}