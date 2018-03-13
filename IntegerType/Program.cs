using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 2147483647;
            Console.WriteLine("Max value that a integer can hold {0}", maxValue);
            Console.ReadKey();
            maxValue += 2;
            Console.WriteLine("Can we increase it?" + maxValue);
            //If we increase a Max int it will add up to negative value 
        }
    }
}
