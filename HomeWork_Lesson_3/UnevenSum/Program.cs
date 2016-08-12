using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddSum
{
    class Program
    {
//        2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//              Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран;
//           б) Добавить обработку исключений на то, что могут быть введены не корректные данные.
//              При возникновении ошибки вывести сообщение и продолжать работу программы.

        static void Main()
        {
            xList = InputNumbers();
            Console.Write("Сумма: ");
            foreach(var i in xList)
            {
                Console.Write(" {0},", i);
                result += i;
            }
            Console.Write(" равна: {0}",result);
            Console.ReadKey();
        }
        public static uint x, result;
        public static List<uint> xList = new List<uint>();
        public static bool IsOdd(uint n)
        {
            return n%2!=0;
        }
        public static List<uint> InputNumbers()
        {
            Console.WriteLine("Введите числа для сложения: ");
            string str="";
            while (str != "0")
            {
            str = Console.ReadLine();
            if (!uint.TryParse(str, out x))
                Console.WriteLine("Ошибка!");
            else
                if (IsOdd(x)) xList.Add(x);
            }
            return xList;
        }
    }
}
