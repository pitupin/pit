using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle_homework_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.Найти количество разрядов числа. 2 - один, 34 - два, 234 - 3 и тд. (Работаем с интовыми переменными) 
            int numberUser = Convert.ToInt32(Console.ReadLine());
            int rank = 0;
            int rankcount = 1; 

            for (int i = 0; i <= numberUser; i++)
            {
                if(i == rankcount)
                {
                    rankcount *= 10;
                    rank++; 
                }
            }
            Console.Write($"Разряд {numberUser} - {rank}");
            Console.ReadKey();
        }
    }
}
