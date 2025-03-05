using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main()
        {
            double[] kv = { 63.50, 63.20, 63.57, 62.87, 64.31, 63.50, 63.24, 64.12, 62.59, 63.78, 63.42, 63.77 };

            // Среднее значение КВ
            double sredneeKV = kv.Average();

            // Максимальное значение КВ и день
            double maxKV = kv.Max();
            int maxKVD = Array.IndexOf(kv, maxKV) + 1;

            // Минимальное значение КВ и день
            double minKV = kv.Min();
            int minKVD = Array.IndexOf(kv, minKV) + 1;

            // Вывод результата
            Console.WriteLine($"Среднее значение КВ = {sredneeKV:F2}.");
            Console.WriteLine($"Максимальная КВ в {maxKVD} день равна {maxKV:F2}.");
            Console.WriteLine($"Минимальная КВ в {minKVD} день равна {minKV:F2}.");
            Console.Read();
        }
    }
}
