using System;

namespace ConsoleApp1.session7
{
    public delegate void ButtonHander(string msg);
    public class EventDemo
    {
        public event ButtonHander Onclick;

        public void ClickButton()
        {
            Console.WriteLine("Button clicked !");
            DateTime now = DateTime.Now;
            if (Onclick == null)
            {
                Onclick += ShowAlert;
            }

            Onclick("User clicked at : " + now);
        }

        public static void ShowAlert(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}