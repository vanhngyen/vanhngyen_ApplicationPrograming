using System;

namespace ConsoleApp1.session6
{
    public delegate int IntegerToInteger(int a, int b);//khai báo 1 delegate trả về int và có 2 tham số;
 
    public class program
    {
        public static void Main(string[] args)
        {
            //tạo 1 đối tượng delegate 
            IntegerToInteger ii = new IntegerToInteger(Calculator.Add);//tham chiếu đến ô nhớ của hàm
            //program.Add(2, 4);
            ii += Calculator.Subtract;//nạp thêm hàm vào chuỗi thực hiện của delegate
            ii += new Calculator().division;
            ii(5, 2);//thực thi các hàm nạp vào delegate 
            //Calculator.Add(2, 6);
            //Calculator.Subtract(4, 6);
            //Calculator.Add(7, 3);
            //Calculator.Subtract(4, 3);
            TaxMoney tm = TaxCalc.GetTax("VN");//tm la 1 delegate
            float tax = tm(100000000);
            Console.WriteLine("thue phai nop :"+tax);
            
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; };

            float frTax = tm2(10000);
            Console.WriteLine("Thue tai phap :"+frTax);
        }
    
    }
}