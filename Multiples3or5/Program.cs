using System;
using System.Linq;

namespace Multiples3or5
{
    class Program
    {
        static void Main(string[] args)
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            //returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0(for languages that do have them).

            //Note: If the number is a multiple of both 3 and 5, only count it once.

            Console.Write("Write the number you want to test: ");
            var result = Solution(Int32.Parse(Console.ReadLine()));
            static int Solution(int value)
            {
                if (value == 0)
                    return 0;

                return Enumerable.Range(0, value)
                                 .Where(x => x % 3 == 0 || x % 5 == 0)
                                 .Sum();
            }

            Console.Write("Write the second number you want to test: ");
            var result2 = Solution2(Int32.Parse(Console.ReadLine()));


            static int Solution2(int value)
            {
                // Magic Happens
                int sum = 0;
                for (int i = 1; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum = sum + i;
                    }
                }
                return sum;
            }

            Console.WriteLine("The result of the first number is: " + result + " and for the second is: "+result2);
        }
    }
}
