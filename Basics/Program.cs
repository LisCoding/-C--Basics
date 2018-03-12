using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {   
            // print hello Liseth 
            Console.WriteLine("Hello there!");            
            string display = ReverseSentence();
            Console.WriteLine("your full name reverse looks like this {0}", display);
            Console.ReadLine();
        }
        /* Create a method that takes an imput fron the user
            then return the input reversed*/

        static string ReverseSentence()
        {
            Console.WriteLine("what is your first Name");
            string fname = Console.ReadLine();
            Console.WriteLine("What is your Last Name");
            string lName = Console.ReadLine();
            return fname + lName;
        }
       static string Reversed(string name)
        {
            return "reversed";
        }
    }
}
