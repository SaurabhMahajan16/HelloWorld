using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class person
    {
        public string firstName;
        public string lastName;
        public int age;
        // we cant use var type for (public we can only use var type for in class variables
        public void intro(string fName, string lName)
        {
            Console.WriteLine("My name is " + fName + " " + lName + " age is " + age);
        }
        public void introduction()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName+ " age is "+ age );
        }
        //static fuinction cannot access public variable
        public static void introduct(string fName, string lName)
        {
            Console.WriteLine("I am static my name is " + fName + " " + lName );
        }
    }
}
