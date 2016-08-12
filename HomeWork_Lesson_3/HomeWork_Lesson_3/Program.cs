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
            //ComplexCalc();
            //FractionsCalc();
        }
        public static void ComplexCalc()
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
                switch (sel)
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
        public static void FractionsCalc()
        {
            Fractions q1 = new Fractions();
            Fractions q2 = new Fractions();
            Fractions qResult = new Fractions();
            string opName = "";

            string exit = "";
            while (exit.ToLower() != "q")
            {
                Console.Clear();
                Console.WriteLine("Введите введите первую дробь");
                q1 = Fractions.Input();
                Console.WriteLine("Введите введите вторйю дробь");
                q2 = Fractions.Input();
                Console.WriteLine("Выберите операцию, которую хотите с ними произвести");
                var sel = Console.ReadLine();
                switch (sel)
                {
                    case "/":
                        qResult = Fractions.Divide(q1, q2);
                        opName = "деление";
                        break;
                    case "*":
                        qResult = Fractions.Multiply(q1, q2);
                        opName = "умножения";
                        break;
                    case "-":
                        qResult = Fractions.Minus(q1, q2);
                        opName = "вычитания";
                        break;
                    case "+":
                        qResult = Fractions.Plus(q1, q2);
                        opName = "сложения";
                        break;
                    default:
                        continue;
                }
                Console.WriteLine("Результат {0} {1} и {2} равен {3}\n", opName, q1, q2, qResult);
                Console.WriteLine("Чтобы выйти введите \"q\".");
                exit = Console.ReadLine();
            }

        }
    }

}
