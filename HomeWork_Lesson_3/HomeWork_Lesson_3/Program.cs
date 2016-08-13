using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeWork_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string x="";
            while(x!="q")
            {
                Console.Clear();
                Console.WriteLine("Главное меню");
                Console.WriteLine("1 - для запуска калькулятора комплексных чисел\n2 - для запуска калькулятора дробей\n3 - для работы с фигурами");
                Console.WriteLine("Введите число: ");
                x = Console.ReadLine();
                switch(x)
                {
                    case "1":
                        ComplexCalc();
                        break;
                    case "2":
                        FractionsCalc();
                        break;
                    case "3":
                        Shapes();
                        break;
                    default:
                        continue;
                }
            }





            //ComplexCalc();
            //FractionsCalc();
            //Shape.Position coord = new Shape.Position();
            //coord.x = 10;
            //coord.y = 10;
            //Circle cir = new Circle(coord, 2);
            //coord.x = 15;
            //coord.y = 10;
            //Square sq = new Square(coord, 3);
            //coord.x = 10;
            //coord.y = 15;
            //Triangle tri = new Triangle(coord, 7, 5, 90);
            //IDrawable draw = new Drawable();



            //draw.DrawCircle(cir);
            //draw.DrawSquare(sq);
            //draw.DrawTriangle(tri);

            //IPrintable print = new Printable();

            //print.DrawSquare(sq);
            //print.DrawTriangle(tri);


            //Shape.Position triangleCoord = new Shape.Position();
            //triangleCoord.x = 10;
            //triangleCoord.y = 10;
            //Shape tr = new Triangle(triangleCoord,5,5,90);

            //var s = tr.Area();

            //Console.WriteLine(tr.ToString());
            //Console.WriteLine(s);

            Console.ReadKey();

        }
        public static void Shapes()
        {
            Console.Clear();
            IDrawable draw = new Drawable();

            Shape.Position cirCoord = new Shape.Position();
            cirCoord.x = 4;
            cirCoord.y = 4;
            Circle cir = new Circle(cirCoord, 2);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("1.Фигура {0}, с радиусом {1} и площадью {2}", cir.ToString(), cir.radius, cir.Area());
            draw.DrawCircle(cir);
            Shape.Position sqCoord = new Shape.Position();
            sqCoord.x = 2;
            sqCoord.y = 9;
            Square sq = new Square(sqCoord, 3);
            Console.SetCursorPosition(1, 8);
            Console.WriteLine("2.Фигура {0}, с длинной стороны {1} и площадью {2}", sq.ToString(), sq.edgeLength, sq.Area());
            draw.DrawSquare(sq);

            Shape.Position triCoord = new Shape.Position();
            triCoord.x = 2;
            triCoord.y = 14;
            Triangle tri = new Triangle(triCoord, 7, 5, 45);
            Console.SetCursorPosition(1, 13);
            Console.WriteLine("3.Фигура {0}, с длинной стороны одной стороны {1}, длиной другой стороны {2}, уголом между ними {3} и площадью {4}", tri.ToString(), tri.edge1, tri.edge2, tri.angle, sq.Area());
            draw.DrawTriangle(tri);
            Console.SetCursorPosition(1, 19);
            Console.WriteLine("Какую фигуру вы хотите распечатать?");
            string str = Console.ReadLine();
            IPrintable print = new Printable();
            switch (str)
            {
                case "1":
                    print.DrawCircle(cir);
                    break;
                case "2":
                    print.DrawSquare(sq);
                    break;
                case "3":
                    print.DrawTriangle(tri);
                    break;
            }
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
