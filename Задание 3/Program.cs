using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            Console.WriteLine("Введите число от 0 до 100:  ");
            string diapazone; 

            diapazone = Console.ReadLine();


            if (Convert.ToInt32(diapazone) >= 0 && Convert.ToInt32(diapazone) <= 14) 
            {
                Console.WriteLine("Вы ввели число в диапазоне от 0 до 14");
            }

             if (Convert.ToInt32(diapazone) >= 15 && Convert.ToInt32(diapazone) <= 35) 
            {
                Console.WriteLine("Вы ввели число в диапазоне от 15 до 35");
            }

            if (Convert.ToInt32(diapazone) >= 36 && Convert.ToInt32(diapazone) <= 50) 
            {
                Console.WriteLine("Вы ввели число в диапазоне от 36 до 50");
            }

            if (Convert.ToInt32(diapazone) >= 50 && Convert.ToInt32(diapazone) <=100)
            {
                Console.WriteLine("Вы ввели число в диапазоне от 50 до 100");
            }

            else if (Convert.ToInt32(diapazone) > 100)
            {
                Console.WriteLine("Это число не входит не в один из заданных промежутков");
            }
            
            Console.ReadKey();
        }
    }
}
