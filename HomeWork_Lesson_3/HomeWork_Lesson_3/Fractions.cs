using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_3
{
    //3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //     Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //    Написать программу, демонстрирующую все разработанные элементы класса.Достаточно решить 2 задачи.Все программы сделайть в одном решении.

    class Fractions
    {
        public int m,n;
        public Fractions()
        {
        }
        public Fractions(int m, int n)
        {
            this.m = m;
            this.n = n;
        }
        public override string ToString()
        {
            return m + "/" + n;
        }
        public double ToDouble()
        {
            return m / n;
        }
        public static Fractions Plus(Fractions q1, Fractions q2)
        {
            Fractions qResult = new Fractions();
            qResult.m = q1.m * q2.n + q2.m * q1.n;
            qResult.n = q1.n * q2.n;
            return qResult;
        }
        public static Fractions Minus(Fractions q1, Fractions q2)
        {
            Fractions qResult = new Fractions();
            qResult.m = q1.m * q2.n - q2.m * q1.n;
            qResult.n = q1.n * q2.n;
            return qResult;
        }
        public static Fractions Multiply(Fractions q1, Fractions q2)
        {
            Fractions qResult = new Fractions();
            qResult.m = q1.m * q2.m;
            qResult.n = q1.n * q2.n;
            return qResult;
        }
        public static Fractions Divide(Fractions q1, Fractions q2)
        {
            Fractions qResult = new Fractions();
            qResult.m = q1.m * q2.n;
            qResult.n = q1.n * q2.m;
            return qResult;
        }
        public static Fractions Input()
        {
            Fractions q = new Fractions();
            while (true)
            {
                Console.Clear();
                Console.Write("Введите число числитель: ");
                if (!int.TryParse(Console.ReadLine(), out q.m))
                {
                    Console.WriteLine("Ошибка!");
                    continue;
                }
                Console.Write("Введите число знаменатель: ");
                if (!int.TryParse(Console.ReadLine(), out q.n))
                {
                    Console.WriteLine("Ошибка!");
                    continue;
                }
                if(q.n==0)
                {
                    Console.WriteLine("Ошибка знаменатель не может быть равен нулю");
                    continue;
                }
                break;
            }
            return q;
        }

    }
}
