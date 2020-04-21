using System;

namespace ConsoleApp1.session3
{
    public abstract class Human
    {
        protected string name;
        protected int age;

        public virtual void addFriend()
        {
            
        }
        
        public virtual void Running()
        {
            Console.WriteLine("Run....");
        }

        public void eat()
        {
            Console.WriteLine("eat ...");
        }
    }
}