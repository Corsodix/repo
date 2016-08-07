using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//A Реализовать авторизацию с запросом логина и пароля.
//Примечание: использовать отдельную функцию, возвращающую булево значение.

//A* Использовать класс System.IO.StreamReader для чтения пароля из файла.


namespace Homework_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!\n");

            bool x = false;
            while(!x) //задаем цикл на повторение проверки ввода логина, пока пароль не будет верен
            {
                x = Authentication.PassCheck();
            }
            while(true)
            {
                Console.WriteLine("Главное меню\n1 - для запуска конвертора десятичной в двоичный\n2 - для запуска калькулятора");
                Console.Write("Введите число: ");

                string select = Console.ReadLine();

                switch(select)
                {
                    case "1":
                        DecimalToBinary.Program.DecToBin();
                        break;
                    case "2":
                        Calculator.Calc();
                        break;
                    default:
                        continue;
                }
            }



            //DecimalToBinary.Program.DecToBin();

            //Calculator.Calc();

            //Console.ReadKey();
        }
    }
}
