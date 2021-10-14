using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // сравнение количества положительных и отрицательных чисел       
            int n = 1; // число положительных чисел
            int k = 1; //число отрицательных чисел
            int a;
            Console.WriteLine("Введите последовательность целых чисел: ");
            Console.WriteLine("Для окончания ввода последовательности введите ноль");
              do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                    n++;
                else
                    if (a != 0)
                    k++;
            }
            while (a != 0);
            if (n > k)
                Console.WriteLine("Количество положительных чисел больше количества отрицательных");
            else
                if (n < k)
                Console.WriteLine("Количество отрицательных чисел больше количества положительных");
            else
                Console.WriteLine("Количество положительных чисел равно количеству отрицательных");
            Console.ReadKey();
        }
    }
}
