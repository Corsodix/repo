using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_2
{
    class Program
    {
        public enum phoneOS
        {
            iOS,
            Android,
            Other
        }
        static void Main(string[] args)
        {
            var x = System.IO.StreamReader();

        }
        private static void ClassWork()
        {
            //Управляющие конструкции
            //if(true) { }
            //else if (true) { }
            //(true) ? true part : false part;
            //var x = 2;
            //var yy = (x == 1) ? (x == 2) ? 22 : 33 : 3;

            //while (true)
            //{
            //    //break; - закончить цикл
            //    //continue; - перейти на следующий цикл
            //}
            //phoneOS phoneS = phoneOS.Android;


            var fiveFactorial = FactorialRecursion(5);


        }
        private static FactorialRecursion(int n)
        {
            //!n
            //!5 = 1 * 2 * 3 * 4 * 5
            if (n == 0)
                return 0;
            if (n == 0)
                return;

            return n * FactorialRecursion(n-1);// результат 120
        }

    }

    
}
//int i;
//if (int.TryParse("", out i)) // попытка преобразования
//{
//    //преобразованная i
//}
//var key = "q";
//if (key.ToLower() == "q") // key == "q" || key == "Q" приведение к нижнему регистру
//{
//}
//string[] strs = new string[] { "a", "b", "c" };
//var result = string.Join(" ", strs);

//var s = string.Format("Вес: {0},Возраст: {1}, Пол: {2}", 85, 30, "Муж");

