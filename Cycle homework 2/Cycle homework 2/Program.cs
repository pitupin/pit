using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle_homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Решение в 10-15 строк, но сразу почти на все пройденные темы)))
           // Перевернуть число. Пользователь вводит число(от 3 цифр и больше), а программа выводит ему число задом-наперед.Например: Ввел 1234, программа вывела 4321.
         // Подсказка.Вспоминайте деление.
                     Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine()); 

            while (number != 0 )
            {
                int remainder = number % 10;
                number = number / 10;
                Console.Write(remainder);
            }
            Console.ReadKey(); 
        }
    }
}
