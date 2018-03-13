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
            //Implicit types 
            var cold = false;
            var grade = 'B';
            var state = "California";
            var number = 12;
            var pi = 3.14;
            Console.WriteLine("these are implicit types {0} {1} {2} {3} {4}", cold, grade, number, pi, state
            );
            number = number + 1;
            /*we declare implicit variables C# will assigned the corresponding 
            Type and assign it to the variable ex: number is a int and we can't add a double
            number += 3.5;
            */
            Console.WriteLine("number has changed " + number);
            Console.ReadLine();


        }
        static int IncreaseAge(int age)
        {
            age += 1;
            return age;
            
        }
        /// <summary>
        /// This method return a string according to 
        /// to the condition 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="letter"></param>
        /// <returns></returns>
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
