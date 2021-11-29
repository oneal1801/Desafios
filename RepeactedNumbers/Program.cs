using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeactedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.Write("Write the amount of numbers you want to insert: ");
            if (!int.TryParse(Console.ReadLine(), out int amount))
                Console.Write("Solo puede digitar Numeros, vuelva a intentar: ");

            int x = amount;

            int[] numbers = new int[x];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int n))
                    Console.Write("Solo puede digitar Numeros, vuelva a intentar: ");
                numbers[i] = n;

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
                    Console.WriteLine($"The Number:{item.Key}: is repeat: {item.Value} times");
                }
            }
        }
    }
}
