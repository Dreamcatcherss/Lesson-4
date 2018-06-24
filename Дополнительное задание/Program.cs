using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дополнительное_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод слов о погоде с русского на английский язык");
            Console.Write("Введите ваше слово: ");

            string word = Console.ReadLine();

            switch (word)

            {
                case "солнечный":
                case "Солнечный":

                    Console.WriteLine("Sunny");
                    break;

                case "дождь":
                case "Дождь":
                    Console.WriteLine("Rain");
                    break;

                case "холод":
                case "Холод":
                    Console.WriteLine("Cold");
                    break;

                case "ветер":
                case "Ветер":
                    Console.WriteLine("Wind");
                    break;

                case "жара":
                case "Жара":
                    Console.WriteLine("Heat");
                    break;

                case "туман":
                case "Туман":
                    Console.WriteLine("Fog");
                    break;

                case "снег":
                case "Снег":
                    Console.WriteLine("Snow");
                    break;

                case "прохладный":
                case "Прохладный":
                    Console.WriteLine("Cool");
                    break;

                case "ливень":
                case "Ливень":
                    Console.WriteLine("Shower");
                    break;

                case "снегопад":
                case "Снегопад":
                    Console.WriteLine("Snowfall");
                    break;

                default:
                    Console.WriteLine("Вы ввели слово не существующее  в нашем словаре");
                    break;
                
            }

            Console.ReadKey();
            
        }
    }
}
