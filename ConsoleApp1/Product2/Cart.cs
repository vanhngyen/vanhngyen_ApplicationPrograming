using System;
using System.Collections.Generic;


namespace ConsoleApp1.Product2
{
    public class Cart:Product2
    {
        protected int id;
        protected string customer;
        protected double grandTotal;
        protected string city;
        protected string country;
        public List<Product2> Product2s_list =new List<Product2>();
        List<Cart> Cart_list = new List<Cart>();

        public Cart()
        {
        }
        

        public Cart(int id, string name, int price, int qty, string image, string desc, string customer, double grandTotal, string city, string country) : base(id, name, price, qty, image, desc)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.city = city;
            this.country = country;
        }

        public int Id1
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public List<Product2> Product2SList
        {
            get => Product2s_list;
            set => Product2s_list = value;
        }

        public List<Cart> CartList
        {
            get => Cart_list;
            set => Cart_list = value;
        }


        public void showInfo()
        {
            Console.WriteLine("Enter id customer : ");
            Id1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter name customer: ");
            Customer = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter City customer : ");
            City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter country customer : ");
            Country = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Customer Info:");
            Console.WriteLine("CustomerID:"+Id1+"| Customer Name:"+Customer+" | City:"+City+" | Country:"+Country); 
            Console.WriteLine("Cart :");
        }
        

        public void RemoveCart()
        {
          
        }

        public void CalculateTotal()
        {
            
        }
    }
}