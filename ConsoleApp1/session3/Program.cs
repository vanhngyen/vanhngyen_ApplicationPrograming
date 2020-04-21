namespace ConsoleApp1.session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m = new Man();
            m.Running();
            m.SayHello();
            m.SayHello("Chao em !");
            Woman woman = new Woman();
            woman.Running();
        }
    }
}