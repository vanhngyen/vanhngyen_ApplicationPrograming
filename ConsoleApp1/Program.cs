using System;
using System.Collections;
using System.Collections.Generic;

//import


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //print
            //String str;
            //str = Console.ReadLine();
            //int no;
            //no = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(no);
            //TotalNumber();
            bien();
        }

        static void TotalNumber(){
            int numberone = 2;
            int numbertwo;
            if (numberone > 2)
            {
                numbertwo = 2;
            }
            else
            {
                numbertwo = 1;
            }

            numbertwo = numberone > 2 ? 2 : 1;
            bool x = numberone > numbertwo;
            {
                switch (x)
                {
                    case true : break;
                    case false : break;
                }
            }

            {
                int[] ary = {1, 2, 3};
                for (int i = 0; i < 3; i++) // cũng vậy nhưng linh hoạt hơn là có thể duyệt nhảy cóc 
                {
                    Console.WriteLine(ary[i]);
                }
//1 2 3 4 5
                foreach (int  y in ary) // duyệt từ đầu đến cuối
                {
                    Console.WriteLine(y);
                }
                double[] ary2 = new Double[5];
                ary2[0] = 1.112;
                ary2[1] = 2.112; //đây là những mảng cổ điển
                ArrayList arrayList = new ArrayList(); //ít dùng
                arrayList.Add(1);
                arrayList.Add("Hello");
                List<int> list = new List<int>();
                list.Add(5);// thêm thông thường của list
                list.Add(5);// thêm thông thường của list
                list[1] = 6; //thêm kiểu chỉ mục (index)
                //nhớ list vẫn là đối tượng của lớp List
                for (int i = 0; i < ary2.Length; i++) //mảng thông thường là length
                {
                    Console.WriteLine(ary2[i]);
                }

                for (int i = 0; i < list.Count; i++) // mảng tập hợp là count
                {
                    Console.WriteLine(list[1]);   
                }

                foreach (int k in list)
                {
                    Console.WriteLine(k);
                }
            }
        }

        static void bien()
        {
            int aNum = 6;
            int bNum = 9;
            int cNum = aNum + bNum;
            
            Console.WriteLine("a + b = c : {0} + {1} = {2}",aNum,bNum,cNum);
        }
    }
}