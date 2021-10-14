using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //нахождение квадрата числа по формуле N^2=1+3+5+...+(2*N-1)
            Console.WriteLine("Введите целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < (2 * N - 1); i += 2)
                Console.WriteLine("вывод промежуточного результата {0} квадрат N равен {1}", j, j+= 1+i);
            Console.ReadKey();
        }
    }
}


