using System.Collections.Generic;

namespace ConsoleApp2.Product
{
    public class Fashion:product
    {
        private string color;
        private int size;

        public Fashion(string color, int size)
        {
            this.color = color;
            this.size = size;     
        }

        public Fashion(int id, string name, double price, uint qty, string image, string desc, List<string> gallery, string color, int size) : base(id, name, price, qty, image, desc, gallery)
        {
            this.color = color;
            this.size = size;
        }

        public bool checkColor(string color)
        {
            if (this.color.Equals(color) && this.Qty >0)
            {
                return true;
            }

            return false;
        }

        public bool CheckSize(int size)
        {
            if (this.size.Equals(size) && Qty >0)
            {
                return true;
            }

            return false;
        }
    }
}