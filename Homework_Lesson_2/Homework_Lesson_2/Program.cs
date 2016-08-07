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

            Calculator.Calc();

            Console.ReadKey();
        }
    }
}
