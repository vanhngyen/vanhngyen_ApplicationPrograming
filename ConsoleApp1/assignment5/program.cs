using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1.assignment5
{
    public class program
    {
        public static void Main(string[] args)
        {
            Phonebook phonebook = new Phonebook();
            phonebook.InsertPhone("vanh","09876543");
            phonebook.updatePhone("vanh2","065432345");
            phonebook.removePhone("vanh");
            phonebook.searchPhone("vanh2");
        }

        
        
    }
}