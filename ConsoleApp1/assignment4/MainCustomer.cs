using System;

namespace ConsoleApp1.assignment4
{
    public class MainCustomer
    {
        //Thực hiện các yêu cầu sau:
        //+ Nhập xuất danh sách các hóa đơn khách hàng.
        //+ Tính tổng số lượng cho từng loại khách hàng.
        //+ Tính trung bình thành tiền của khách hàng người nước ngoài.
        //+ Xuất ra các hoá đơn trong tháng 01 năm 2019 (cùa cả 2 loại khách hàng).

        public static void Main(string[] args)
        {
            CustomerVN vn = new CustomerVN(1,"vanh","2/2/2020","kinh doanh",20,100,100);
            Console.WriteLine(" Customer id :"+vn.Id + " | Customer name :"+vn.Name+" | date : "+vn.Date +" | Customers : "+vn.Customers+" | amount : "+vn.Amount+" | Unit Price : "+vn.UnitPrice+" | Quota : "+vn.Quota);
            Console.WriteLine(" Total : "+vn.Amount);
            CustomerNN nn = new CustomerNN(1,"vanh","2/1/2019","Anh",100,100);
            Console.WriteLine(" Customer id :"+nn.Id + " | Customer name :"+nn.Name+" | date : "+nn.Date +" | Nationality : "+nn.Nationality+" | Amount : "+nn.Amount+" | Unit Price : "+nn.UnitPrice);
            nn.Into_money();
            
            

        }

    }
}