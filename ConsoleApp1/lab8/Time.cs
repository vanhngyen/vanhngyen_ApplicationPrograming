using System;
using System.Threading;

namespace ConsoleApp1.lab8
{
    public class Time
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(countdown); 
            t1.Start();
        }

        public static void countdown()
        {
            Console.WriteLine("Trigger bomb ");
            int minute = 10;
            int second = 59;
            for (int i = minute ;i>=0;i--){
                for (int j = second ; j>=0;j--) {
                   Console.WriteLine(i+":"+j);
                    try {
                        Thread.Sleep(100);
                    } catch (Exception e) {

                    }
                }
            }
            Console.WriteLine("boom.....");
        }
    }
}