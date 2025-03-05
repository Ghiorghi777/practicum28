using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            // Инициализация массива явным образом
            int[] array = { 3, 8, 1, 5, 12, 7, 4, 9 };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Найдём максимальный элемент и его индекс
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Обмен первого и максимального элементов
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;

            Console.WriteLine("\nМассив после замены:");
            PrintArray(array);
        }

        // Метод для вывода массива
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
