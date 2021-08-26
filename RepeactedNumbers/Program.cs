using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeactedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Steven!");

            Console.Write("Digite la cantidad de numeros que desea digitar: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[x];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Dictionary<int, int> RepeatedNumbers = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (RepeatedNumbers.ContainsKey(number))
                {
                    RepeatedNumbers[number] += 1;
                }
                else
                {
                    RepeatedNumbers.Add(number, 1);
                }
            }

            foreach (var item in RepeatedNumbers.ToList())
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"El numero:{item.Key}: se repite: {item.Value}");
                }
            }
        }
    }
}
