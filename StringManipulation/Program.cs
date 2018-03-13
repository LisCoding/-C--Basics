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
            Console.WriteLine(NameLength());
            FindingLetters("hel");
            FindingLetters("banana");
            Yelling("Het there!");
            Yelling("YOO");
            RemoveFirstAndLast("Liseth");
            Console.ReadLine();         
        }
        //finds the length of a string
        static int NameLength()
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            return name.Length;
        }
        //Indexing strings 
        static void FindingLetters(string word)

        {
            int middleIndex = word.Length / 2;
            Console.WriteLine("first leter is {0}", word[0]);
            Console.WriteLine("last leter is {0}", word[word.Length-1]);
            Console.WriteLine("middle leter is {0}", word[middleIndex]);
        }

        //Changing case
        static void Yelling(string word)
        {
            if(word.Length > 5)
            {
                Console.WriteLine("Shout...{0}", word.ToUpper());
            } else
            {
                
                Console.WriteLine(word.ToLower());

            }
        }

        //Getting parts of String
        static void RemoveFirstAndLast(string word)
        {
            word =  word.Remove(0, 1).Remove(word.Length-2);
            Console.WriteLine(word);
            string phrase = "hey it is a beautiful day";
            string removeLetters = phrase.Remove(4, 3);
            Console.WriteLine(removeLetters);
            word = word.Replace('e', 't');
            Console.WriteLine(word);
        }

    }
}
