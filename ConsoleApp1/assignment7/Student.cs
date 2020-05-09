using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApp1.assignment7
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private string address;
        private double gpa; //Grade Point Average 

        public Student()
        {
        }

        public Student(int id, string name, int age, string address, double gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public double Gpa
        {
            get => gpa;
            set => gpa = value;
        }

        List<Student> list = new List<Student>();
        

        public void AddStudent()
        {
            Console.WriteLine("Enter id :");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name :");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter age :");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter address :");
            Address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Gpa :");
            Gpa = Convert.ToDouble(Console.ReadLine());
            list.Add(new Student(id,name,age,address,Gpa));
        }

        public void EditStudentId()
        {
            string NameNew = null;
            int AgeNew = 0;
            string AddressNew = null;
            double GpaNew = 0.0;
            
            Console.WriteLine("Enter id :");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Name New :");
            NameNew = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Age New :");
            AgeNew = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address New :");
            AddressNew = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Gpa New :");
            GpaNew = Convert.ToDouble(Console.ReadLine());

            var index = list.FindIndex(student => student.id.Equals(id));
            list[index] = new Student(id, NameNew, AgeNew, AddressNew, GpaNew);
            Console.WriteLine(index);
            Show();
        }


        public void DeleteStudent()
        {
            Console.WriteLine("Enter id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            var index = list.FindIndex(student => student.id.Equals(id));
            list.RemoveAt(index);
        }
        
        public void SortGpa()
        {
            list.Sort((x, y) => x.gpa.CompareTo(y.gpa));
            Show();
        }
        
        public void SortName()
        {
            list.Sort((x, y) => x.name.CompareTo(y.name));
            Show();
        }
        

        public void Show()
        {
            foreach (Student studentlist in list)
            {
                Console.WriteLine("Id : "+studentlist.Id+"  |  Name : "+studentlist.Name+"  |  Age : "+studentlist.Age+"  |  Address : "+studentlist.Address +"  |  Gpa :"+studentlist.Gpa);
            }
        }
        
    }
}