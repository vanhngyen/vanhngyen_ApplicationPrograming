using System;
using System.Collections.Generic;

namespace ConsoleApp1.Product2
{
    public class CartMain
    {
        public static void Main(string[] args)
        {
            Product2 product2 = new Product2();
            Cart cart = new Cart();
            while (true)
            {
                Console.WriteLine("----------  Cart ---------- ");
                Console.WriteLine("1 . add ");
                Console.WriteLine("2 . Remove ");
                Console.WriteLine("3 . Total ");
                Console.WriteLine("Enter  : ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1 :
                        cart.addProduct();
                        cart.showInfo();
                        cart.showListProducts();
                        break;
                    case 2:
                        cart.RemoveCart();
                        cart.showListProducts();
                        break;
                    case 3:
                        cart.CalculateTotal();
                        break;
                    default:
                        Console.WriteLine("the end !");
                        break;
                }
            }
        }
    }
}