using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace ConsoleApp2.Product
{
    public delegate void ShowAlert(string msg);
    public class Cart
    {

        private int id;
        private string customer;
        private double grandtotal;
        private List<product> ListProduct;
        private string city;
        private string country;

        public Cart()
        {
        }
        public event ShowAlert AddToCart;

        
        public Cart(int id, string customer, double grandtotal, List<product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandtotal = grandtotal;
            ListProduct = listProduct;
            this.city = city;
            this.country = country;
            if (AddToCart == null)
            {
                AddToCart += AlertMessage;
            }
            
        }
        
        public static void AlertMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double Grandtotal
        {
            get => grandtotal;
            set => grandtotal = value;
        }

        public List<product> ListProduct1
        {
            get => ListProduct;
            set => ListProduct = value;
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

      
        
        
        public bool addProduct(product products)
        {
            ListProduct.Add(products);
            //thêm tiền trong grandtotal
            //phat su kien
            AddToCart("da them sp " + products.Name + "vao gio hang");
            return true;
        }

        public bool removeProduct(product products)
        {
            //tru tiền trong grandtotal
            return ListProduct.Remove(products);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (product p in ListProduct)
            {
                grand += p.Price;//chạy vào hàm get
            }

            grand += ShippingFee(grand); //chạy vào hàm set trong properties
            this.Grandtotal = grand;
            return grandtotal;
        }

        public double ShippingFee(double grand)
        {
            if (country.Equals("VN") && (city.Equals("HN") || city.Equals("HCM")))
            {
                 return grand * 0.01;
            }
            if(country.Equals("VN"))
            {
                return grand * 1.02;
            }
                return grand * 1.05;
        }
    }
}