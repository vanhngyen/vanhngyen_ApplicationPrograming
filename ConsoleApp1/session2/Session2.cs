using System;

namespace ConsoleApp1
{
    public class Session2
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();//s1 là 1 đối tượng tạo ra từ lớp student
            //về mặt bản chất thì new student mới là đối tượng --> tạo 1 ô nhớ chứa gồm : name , age , function showInfo
            s1.ShowName();
            Social.Hello();
            Console.WriteLine(Social.FirstWeekOfYear+10);//ClassName.varname
        }
    }
}