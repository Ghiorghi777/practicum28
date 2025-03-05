using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[9];
            Random rand = new Random();
            int evenCount = 0, oddCount = 0;

            // Заполнение массива случайными числами и вывод
            Console.WriteLine("Массив случайных чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100); // Генерация случайных чисел от 1 до 99
                Console.Write(array[i] + " ");

                // Проверка четности
                if (array[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("\nЧетных элементов: " + evenCount);
            Console.WriteLine("Нечетных элементов: " + oddCount);

            if (evenCount > oddCount)
                Console.WriteLine("Четных элементов больше.");
            else if (oddCount > evenCount)
                Console.WriteLine("Нечетных элементов больше.");
            else
                Console.WriteLine("Четных и нечетных элементов поровну.");
            Console.Read();
        }
    }
}
