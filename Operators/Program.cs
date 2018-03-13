using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3; //4
            int y = 5; //6
            // the old value of x is assigned to z then x is incremennted
            int z = x++; //3

            //here y is first incremented then k is assigned to y
            int k = ++y; //6
            /*y = x++ + ++x;
             x++ = 4, x = 5
            ++x = 6 */
            int a = 10;
            int b = 12;
            int d = a--;
            int f = --b;


            

            Console.WriteLine("The value of x is {0} and y is {1}", x, y);
            Console.WriteLine("The value of z is {0} and k is {1}",z, k);
            Console.ReadLine();
            Console.WriteLine("What happened if we decrement any guess?");
            Console.WriteLine("a is " + a + "...b is " + b +
                "...d is " + d + " f is " + f);
            Console.ReadLine();
        }
    }
}
