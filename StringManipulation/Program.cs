using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string poem = "Hello fron the other side \nI call you 100 times";
            string quote = "hey always use \\ to not  comment your code";
            string url = @"https://onedrive.com";
            string life = "love and 'live' for ever";
            Console.WriteLine(poem + life);
            Console.WriteLine(quote);
            Console.WriteLine("this is my website: {0}", url);
            Console.ReadLine();         
        }
    }
}
