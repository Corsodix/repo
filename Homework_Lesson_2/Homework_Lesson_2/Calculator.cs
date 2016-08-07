using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//B Реализовать простой калькулятор.Система запрашивает знак операции, затем первый операнд и второй операнд. Выводится результат вычисления.

//B.1. Добавить защиту от ввода не числовых данных.Используйте для этого TryParse

namespace Homework_Lesson_2
{
    class Calculator
    {
        public enum operations
        {
            add = '+',
            subtrack = '-',
            divide = '/',
            multiply = '*'
        }
        public static void Calc()
        {
            string exit = "a";
            while(exit.ToLower() != "q")
            {
                int x, y;
                float result = 0.0f;
                char sym;
                Console.Clear();
                Console.WriteLine("Калкулятор\n");
                Console.Write("Введите знак операции: ");
                if (!char.TryParse(Console.ReadLine(), out sym))
                    continue;
                Console.Write("Введите введите первую цифру: ");
                if (!int.TryParse(Console.ReadLine(), out x))
                    continue;
                Console.Write("Введите введите вторую цифру: ");
                if (!int.TryParse(Console.ReadLine(), out y))
                    continue;

                switch(sym)
                {
                    case (char) operations.add:
                        result = (float) x + y;
                        break;
                    case (char)operations.subtrack:
                        result = (float) x - y;
                        break;
                    case (char)operations.divide:
                        result = (float) x / y;
                        break;
                    case (char)operations.multiply:
                        result = (float) x * y;
                        break;
                }
                Console.WriteLine("{0} {1} {2} = {3}\n", x, sym, y, result);
                Console.WriteLine("Чтобы выйти введите \"q\".");
                exit = Console.ReadLine();

            }
        }
    }
}
