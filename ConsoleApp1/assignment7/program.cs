using System;

namespace ConsoleApp1.assignment7
{
    public class program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(); 
            int choose;
            do
            {
                Menu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1 :
                        student1.AddStudent();
                        student1.Show();
                        break;
                    case 2:
                        student1.EditStudentId();
                        break;
                    case 3:
                        student1.DeleteStudent();
                        student1.Show();
                        break;
                    case 4:
                        student1.SortGpa();
                        break;
                    case 5:
                        student1.SortName();
                        break;
                    case 6:
                        student1.Show();
                        break;
                    default:
                        Console.WriteLine("the end !");
                        break;
                }
            } while (choose != 0);
        }

        public static void Menu()
        {
            Console.WriteLine("------ Student -------");
            Console.WriteLine("1 . Add student .");
            Console.WriteLine("2 . Edit student .");
            Console.WriteLine("3 . Remove student .");
            Console.WriteLine("4 . Sort student gpa .");
            Console.WriteLine("5 . Sort Name student .");
            Console.WriteLine("6 . Show student .");
            Console.WriteLine("0 . Exit .");
            Console.WriteLine("Enter : " );
            
        }
    }
}