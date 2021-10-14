using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // найти количество квадратов на прямоугольнике
            Console.Write("Введите A>0: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B>0: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C>0: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++;
            }
            while (b >= c)
            {
                b -= c;
                n++;
            }
            int square = 0;
            for (int i = 0; i < k; i++)
                square += n;
            Console.WriteLine("Количество квадратов, размещенных в прямоугольнике равно " + square);
            Console.ReadKey();
        }
    }
}
