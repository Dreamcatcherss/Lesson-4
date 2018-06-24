using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 15;
            double operand2 = 3;
            double result = 0;
           

            Console.WriteLine("Введите знак арифметической операции +,-,*,/");

            string sign = Console.ReadLine();

            switch (sign)

            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("Ваш ответ:  {0}", result);
                    break;

                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("Ваш ответ:  {0}", result);
                    break;

                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine("Ваш ответ:  {0}", result);
                    break;

                case "/":
                    result = operand1 / operand2;
                    Console.WriteLine("Ваш ответ:  {0}", result);
                    break;
            }
           
            if (result == operand1 / 0)
            {
                Console.WriteLine("Ошибка: на 0 делить нельзя");
            }
          
            Console.ReadKey();
        }
    }
}
