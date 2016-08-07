using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    public class Program
    {
        public static List<int> numList = new List<int>();

        static void Main(string[] args)
        {
            int inputNumber;
            string exit = "";
            while (exit.ToLower() != "q") //создаем рабочий цикл
            {
                Console.Clear();    //очищаем экран
                Console.WriteLine("Перевод десятичной цифры в двоичную\n");
                Console.Write("Введите число: ");
                if (!int.TryParse(Console.ReadLine(), out inputNumber))     //выводим сообщение и запрашиваем цифру
                    continue;
                var recNumber = Recursion(inputNumber);         //вызываем функцию и вводим полученное значение в переменную
                Console.WriteLine("{0} в двоичном выражении это {1}", inputNumber, recNumber); // выводим результат на экран
                Program.numList.Clear();        //очищаем список значений

                Console.WriteLine("Чтобы выйти введите \"q\".");
                exit = Console.ReadLine();
            }
        }

        public static void DecToBin()
        {
            int inputNumber;
            string exit = "";
            while (exit.ToLower() != "q") //создаем рабочий цикл
            {
                Console.Clear();    //очищаем экран
                Console.WriteLine("Перевод десятичной цифры в двоичную\n");
                Console.Write("Введите число: ");
                if (!int.TryParse(Console.ReadLine(), out inputNumber))     //выводим сообщение и запрашиваем цифру
                    continue;
                var recNumber = Recursion(inputNumber);         //вызываем функцию и вводим полученное значение в переменную
                Console.WriteLine("{0} в двоичном выражении это {1}", inputNumber, recNumber); // выводим результат на экран
                Program.numList.Clear();        //очищаем список значений

                Console.WriteLine("Чтобы выйти введите \"q\".");
                exit = Console.ReadLine();
            }

        }
        static ulong Recursion(int n)
        {
            int x = n / 2;      // вводим временную переменную и даем ей значение равное половине вводной цифры
            Program.numList.Add(n - x * 2); // в результате вычитания получаем 1 или 0 и это значение добавляем в список 
            string tempString = "";
            ulong output;
            if (n == 1) // когда значение больше не можем дельться, запускаем цикл
            {
                for (int i= numList.Count-1; i>=0;i--)
                    tempString = tempString + numList[i].ToString();
                if (!ulong.TryParse(tempString, out output)) // переводим все значения списка в строку, а затем эту строку переводим в цифровое значение, 
                    return 0; //  проверяем, чтобы оно было не слишком длинное, если оно слишком длинное возвращаем 0
                else return output;  // если конвертация удалась, возвращаем двоичное значение
            }
            return Recursion(n/2);
        }
    }
}
