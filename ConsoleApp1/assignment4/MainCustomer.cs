using System;
using System.Collections.Generic;

namespace ConsoleApp1.assignment4
{
    public class MainCustomer
    {
        public static void Main(string[] args)
        {
            List<CustomerVN> listVN = new List<CustomerVN>();
            listVN.Add(new CustomerVN(1,"nguyễn văn an","01/2019",155,"sinh hoạt"));
            List<CustomerNN> listNN = new List<CustomerNN>();
            listNN.Add(new CustomerNN(2,"Alex","01/2019",78,"US"));
            listNN.Add(new CustomerNN(3,"Micheal","01/2019",122,"UK"));
            listVN.Add(new CustomerVN(4,"Lê Minh Anh","01/2019",255,"sinh hoạt"));
            int totalVN = 0;
            foreach (CustomerVN x in listVN)
            {
                totalVN += x.ThanhTien();
            }

            int totalNN = 0;
            foreach (CustomerNN x in listNN)
            {
                totalNN += x.ThanhTien();
            }
            Console.WriteLine("VN: "+totalVN);
            Console.WriteLine("NN: "+totalNN);
            Console.WriteLine("Trung binh:");
            Console.WriteLine("VN: "+((float)totalVN/listVN.Count));
            Console.WriteLine("NN: "+((float)totalNN/listNN.Count));
            Console.WriteLine("Hoa don thang 1/2019");
            foreach (CustomerVN x in listVN)
            {
                if (x.BillDate.Equals("01/2019"))
                {
                    x.ShowBill();
                }
            }
            foreach (CustomerNN x in listNN)
            {
                if (x.BillDate.Equals("01/2019"))
                {
                    x.ShowBill();
                }
            }
        }
    }
}