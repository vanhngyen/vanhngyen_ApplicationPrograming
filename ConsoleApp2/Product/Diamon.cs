using System.Collections.Generic;

namespace ConsoleApp2.Product
{
    public class Diamon:product
    {
        private uint cara;

        public Diamon(uint cara)
        {
            this.cara = cara;
        }

        public Diamon(int id, string name, double price, uint qty, string image, string desc, List<string> gallery, uint cara) : base(id, name, price, qty, image, desc, gallery)
        {
            this.cara = cara;
        }

        public bool IsReal()
        {
            //công thưc kiêm tra nao đó
            if (cara > 5) return true;
            return false;
        }
    }
}