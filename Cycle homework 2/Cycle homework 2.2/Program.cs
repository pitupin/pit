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
            //1.Пользователь вводит число, найти все делители этого числа. 
            int numberUser = 0;
            bool isValididInput;
            do
            {
                isValididInput = int.TryParse(Console.ReadLine(), out numberUser);
            } while (isValididInput != true); 
            for (int i = 1; i <= numberUser; i++)
            {
                 if(numberUser % i == 0)
                {
                    Console.Write($"{i};");
                }
            }
            Console.ReadKey();
        }
    }
}
