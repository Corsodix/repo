using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            RefDemo(ref x); //ссылка на х меняется в методе 
            int total = 0;
            var arr = OutDemo(out total);
            ParamsArguments(1, "2", "asd", "3", wrod:);
            BoxingDemo((object)x);

        }
        static void Array()
        {
            int[] ages = new int[] { };
            int[] ages2 = { };

        }
        static void RefDemo(ref int x)
        {
            x = 3; 
        }
        static int[] OutDemo(out int total) // вывод дополнительного параметра
        {
            int count = 10;
            total = count;
            return new int[1] { 1 };
        }
        static void ParamsArguments(int x,params string[] words)// params самый последний аргумент функции(
        {
        }
        static void BoxingDemo(object x)
        {
            int _x = (int)x; //unboxing

        }
    }

    class shape
    {
        public string qwe { get; set; }
    }

}
