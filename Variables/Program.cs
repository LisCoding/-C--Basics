using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hungry = true;
            int age = 21;
            double score = 3.5;
            char letter = 'A';
            string name = "Liseth";
            Console.WriteLine("you are {0} years old", age);
            age = IncreaseAge(age);
            Console.WriteLine("Now you are one year older {0}",age);
            Console.WriteLine("Hi {0} your are {1} and your score is {2}", name, age, score);
            Console.WriteLine(BuyFood(hungry, letter));
            Console.ReadLine();

        }
        static int IncreaseAge(int age)
        {
            age += 1;
            return age;
            
        }
        static string BuyFood(bool status, char letter)
        {
            if (status && letter == 'A')
            {
                return "Time to buy food, you did it";
            }
            else if (letter == 'A')
            {
                return "you deserve a great food";
            }
            else
            {
                return "keep crushing code";
            }
        }

    }
}
