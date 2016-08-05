using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
        FromStart:
            Console.Clear();
            Console.WriteLine("Главное меню\n\nДля выбора \"Cуммирование\" введите 1\nДля выбора \"Анкета\" введите 2\nДля выбора \"Зарплата\" введите 3\nДля выхода нажмите \"q\"");
            Console.Write("Введите свой выбор: ");
            string Sel = Console.ReadLine();
            switch (Sel)
            {
                case "1":
                    Sum();
                    goto FromStart;
                case "2":
                    Form();
                    goto FromStart;
                case "3":
                    Salary();
                    goto FromStart;
                default:
                    Console.WriteLine("Неправельный выбор!\nНажмите любую клавишу, чтобы продолжить");
                    Console.ReadKey();
                    goto FromStart;
                case "q":
                    break;
            }
        }
        static void Sum()
        {
            while (true)
            {
                //На вход подается два числа(операнда).На выходе выводится результат сложения.
            again:
                Console.Clear();
                Console.WriteLine("Суммирование\n");
                Console.Write("Введите число х: ");
                string xStr = Console.ReadLine();
                Console.Write("Введите число y: ");
                string yStr = Console.ReadLine();

                int x = Convert.ToInt32(xStr); 
                int y = Convert.ToInt32(yStr);

                int z = x + y;

                Console.WriteLine("Результат сложения " + x + " и " + y + " равен " + z);

                Console.WriteLine("Чтобы повторить нажмите \"Enter\",\nДля возврата в главное меню введите \"q\".");
                string e = Console.ReadLine();
                if (e == "q")
                    break;
                else
                    goto again;

            }
        }
        static void Form()
        {
            // (имя, фамилия, возраст, город рождения, рост, вес). В результате выводится вся информация в одну строчку.
            Console.Clear();
            Console.WriteLine("Анкета\n");
            Console.WriteLine("Введите свои данные");
            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Город рождения: ");
            string city = Console.ReadLine();

            Console.Write("Рост: ");
            string height = Console.ReadLine();

            Console.Write("Вес: ");
            string weight = Console.ReadLine();

            //Console.WriteLine(name + " " + surname + ", " + age + ", " + city + ", " + height + ", " + weight);
            Console.WriteLine("\n{0} {1}, {2}, {3}, {4}, {5}", name, surname, age, city, height, weight);
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню.");
            Console.ReadKey();
        }
        static void Salary()
        {
            //определяет заработок пользователя за год, неделю, сутки, час, минуту.На вход подается зарплата за месяц
            Console.Clear();
            Console.WriteLine("Зарплата\n");
            Console.Write("Введите свою зарплату в месяц: ");

            float month = float.Parse(Console.ReadLine());
            float year = month * 12;
            float week = month / 4;
            float day = week / 7;
            float hour = day / 24;
            float minute = hour / 60;

            Console.WriteLine("Зарплата в год: {0:#.##} руб", year);
            Console.WriteLine("Зарплата в неделю: {0:#.##} руб", week);
            Console.WriteLine("Зарплата в день: {0:#.##} руб", day);
            Console.WriteLine("Зарплата в час: {0:#.##} руб", hour);
            Console.WriteLine("Зарплата в минуту: {0:#.##} руб", minute);
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню.");
            Console.ReadKey();
        }
    }
}
