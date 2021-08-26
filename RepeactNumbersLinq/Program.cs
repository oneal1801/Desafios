using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeactNumbersLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de numeros que desea digitar: ");
            int x = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 1; i <= x; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));

                }
            }


            var RepeatedNumbers = numbers.GroupBy(z => z).Select(s => new { Numero = s.Key, Cantidad = s.Count() }).ToList();


            foreach (var item in RepeatedNumbers.ToList())
            {
                if (item.Cantidad > 1)
                {
                    Console.WriteLine($"El numero:{item.Numero}: se repite: {item.Cantidad}");
                }
            }
        }
    }
}
