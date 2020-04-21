using System;

namespace ConsoleApp1.session3
{
    public class Man:Human,IHuman
    {
        public void SayHello()
        {
            Console.WriteLine("Hello everybody !");
            
        }
        
        
        public void SayHello(string m)
        {
            Console.WriteLine(m);
        }

        public override void addFriend()
        {
            
        }

        public void alo()
        {
            throw new NotImplementedException();
        }
    }
}