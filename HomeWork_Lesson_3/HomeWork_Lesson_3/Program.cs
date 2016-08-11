using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex cNumber1 = new Complex();
            Complex cNumber2 = new Complex();
            Complex cNumberResult = new Complex();
            string opName = "";

            string exit = "";
            while (exit.ToLower() != "q")
            {
                Console.Clear();
                Console.WriteLine("Введите введите первое комплексное число");
                cNumber1 = Complex.Input();
                Console.WriteLine("Введите введите второе комплексное число");
                cNumber2 = Complex.Input();
                Console.WriteLine("Выберите операцию, которую хотите с ними произвести");
                var sel = Console.ReadLine();
                switch(sel)
                {
                    case "/":
                        cNumberResult = Complex.Divide(cNumber1, cNumber2);
                        opName = "деление";
                        break;
                    case "*":
                        cNumberResult = Complex.Multiply(cNumber1, cNumber2);
                        opName = "умножения";
                        break;
                    case "-":
                        cNumberResult = Complex.Minus(cNumber1, cNumber2);
                        opName = "вычитания";
                        break;
                    case "+":
                        cNumberResult = Complex.Plus(cNumber1, cNumber2);
                        opName = "сложения";
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("Результат {0} {1} и {2} равен {3}\n", opName, cNumber1, cNumber2, cNumberResult);
                Console.WriteLine("Чтобы выйти введите \"q\".");
                exit = Console.ReadLine();
            }
        }
    }

}
