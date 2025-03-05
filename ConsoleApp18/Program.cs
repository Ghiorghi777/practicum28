using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[14];
            int evenCount = 0;

            Console.WriteLine("Введите 14 целых чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
            Console.Read();
        }
    }
}
