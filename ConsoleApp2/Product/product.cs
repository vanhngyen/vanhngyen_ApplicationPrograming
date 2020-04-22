using System;
using System.Collections.Generic;

namespace ConsoleApp2.Product
{
    public class product
    {
        protected int id;
        protected string name;
        protected double price;
        protected uint Qty; //uint đảm bảo số lượng k âm
        protected string image;
        protected string desc;
        protected List<string> gallery;

        public product()
        {
            this.gallery = new List<string>();
        }

        public product(int id, string name, double price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            Qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public uint Qty1
        {
            get => Qty;
            set => Qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery; // kiểu lambda expression
            set => gallery = value;
        }

        public void getInfo()
        {
            Console.WriteLine("Id : "+this.id +" | Name : "+this.name +" | qty :"+Qty);
        }

        public bool CheckStock()
        {
            if (Qty>0)
            {
                return true;
            }

            return false;
        }

        public bool addGallery(string image)
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("Ảnh vượt qá số lượng !");
                return false;
            }
           // Console.WriteLine("nhạp tu ban phim");
            //string new_image = Console.ReadLine();
            //gallery.Add(new_image);
            
            gallery.Add(image);
            return true;
        }

        public void deleteGallery()
        {
            Console.WriteLine("danh danh anh :");
            for (int i = 0; i < gallery.Count; i++)
            {
                Console.WriteLine((i+1)+"."+gallery[i]);
            }
            Console.WriteLine("Chon de xoa !");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number < gallery.Count && number>0)
            {
                gallery.RemoveAt(number);
                return true;
            }

            return false;
        }
    }
}