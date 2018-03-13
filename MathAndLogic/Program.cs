using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 23;
            int b = 7;
            int c = 8;

            int x = a++;
            int y = --b;
            int z = ++c;
            Console.WriteLine(EvenNumber(x));
            Console.WriteLine(DivisibleByThree(y));
            Console.WriteLine(RoundNumber(3.4579));
            DoublesToInt();

          
        }


        //3. Write an expression that returns true if x is even, and false if x is odd.
        //Store the result of the expression in a bool.
        static bool EvenNumber(int number)
        {
           if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //4. Write an expression that returns false if y is divisible by 3. Store the result of the expression in a bool 

       static bool DivisibleByThree(int number)
        {
            if (number % 3 == 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        //5. Write an expression that rounds a double to 3 
        //decimal places and store the result in a double.

        static double RoundNumber(double number)
        {
            double result = Math.Round(number, 3);
            return result;
        }

        //Type Conversion Convert int to doubles 
        static void DoublesToInt()
        {
            int score = 95;
            int saving = 145;
            int number = 45;


            double money = 10.45;
            double days = 7;
            double c = 56.2;
            //Store the integers in the doubles
            days = (double)saving; // we do not need to cast int to double
            
            //We need to cast when converting from double to integer
            score = (int)c;
            number = (int)money;

            Console.WriteLine("score is" + score);
            Console.WriteLine("c is" + c);


        }

        



    }
}
