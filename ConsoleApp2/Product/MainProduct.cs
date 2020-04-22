using System;
using System.Collections.Generic;

namespace ConsoleApp2.Product
{
    public class MainProduct
    {
        public static void Main(string[] args)
        {
            product p1 = new product(1,"sanpham1",2,4,"anh1", "mota sp 1",new List<string>());
            p1.addGallery("a");
            Fashion f1 = new Fashion(2,"abc",100,3,"fd","mota",new List<string>(),"red",2 );
            Diamon d1 = new Diamon(3,"bd",32,3,"sf","sd",new List<string>(),3 );
            Cart c1 = new Cart(1,"vds",4,new List<product>(),"HN","VN" );
            c1.addProduct(p1);
            c1.addProduct(f1);
            c1.addProduct(d1);
            Console.WriteLine("Tong tien :"+c1.FinalTotal());
        }
    }
}