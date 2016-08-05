using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class SomeClass
    {
        public int Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {

                

                Console.Clear();

                Console.WriteLine("Введите число x ");
                string xString = Console.ReadLine();
                Console.WriteLine("Введите число y ");
                string yString = Console.ReadLine();

                int x = int.Parse(xString);
                int y = int.Parse(yString);

                int sum = x + y;

                Console.WriteLine("x + y = " + sum);

                Console.WriteLine("Для выхода введите q ");

                Console.ReadKey();
            }

        }

        static void ChangeObject(SomeClass obj)
        {
            obj.Value = obj.Value + 1;
        }

        static void SumShow()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("number X");
                string xString = Console.ReadLine();

                Console.WriteLine("number Y");
                string yString = Console.ReadLine();

                int x = int.Parse(xString);
                int y = int.Parse(yString);


                var sum = Sum(x, y);

                Console.WriteLine("Summary " + sum);

                Console.WriteLine("press any key");

                var input = Console.ReadLine();

                if (input == "q")
                    break;
            }
        }



        static int Sum(int x, int y)
        {
            int result = x = y;

            return result;
        }
    }
}
