using System;
using System.Collections.Generic;

namespace ConsoleApp1.Product2
{
    public class Fashion:Product2
    {
        protected string coler;
        protected string size;
        List<Fashion> listfashion = new List<Fashion>();

        public Fashion()
        {
        }

        public Fashion(string coler, string size)
        {
            this.coler = coler;
            this.size = size;
        }

        public Fashion(int id, string name, int price, int qty, string image, string desc, string coler, string size) : base(id, name, price, qty, image, desc)
        {
            this.coler = coler;
            this.size = size;
        }


        public void check()
        {
            if (listfashion.Count > 0)
            {
                Console.WriteLine("stocking .");
            }
            else
            {
                Console.WriteLine("Out of stock !");
            }
        }
        
    }
}