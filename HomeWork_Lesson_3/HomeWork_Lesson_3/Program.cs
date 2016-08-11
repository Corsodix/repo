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
            Complex cn = new Complex();
            cn.re = 4;
            cn.im = 1;

            Console.WriteLine("Введите комплексное число, например 12+5i");
            var s = "15+5i";//Console.ReadLine().Trim();
            int a, b;
            string aStr = "";
            var x = s.Length;

            foreach (int i in s)
            {
                if (s[i] == '+')
                {
                    int.TryParse(aStr, out a);
                    continue;
                }
                if (s[i] == 'i')
                {
                    int.TryParse(aStr, out b);
                    break;
                }
                aStr += s[i];

            }







            Complex z;
            //cn.Plus(cn,);
            Console.WriteLine(cn.ToString());
            z = Complex.Plus(cn, cn);
            Console.WriteLine(z);
            z = Complex.Minus(cn, cn);
            Console.WriteLine(z);
            z = Complex.Multi(cn, cn);
            Console.WriteLine(z);
            z = Complex.Divide(cn, cn);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }

}
