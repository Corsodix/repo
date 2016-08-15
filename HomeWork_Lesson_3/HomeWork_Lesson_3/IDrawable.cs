using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork_Lesson_3
{
    //5. * Опишите и реализуйте интерфейс: IDrawable для иехрархии созданных объектов в п.4. 
    //    Реализация интерфейса должна выводить в консоли нечто похожее на тот объект, для кого метод отрисовки был вызван.
    //    IPrintable(наследует от IDrawable), обеспечивает распечатывание объекта на принтере(достаточно просто вывести информационное сообщение в консоль).
    //    Использует результат работы IDrawable чтобы распечатать его на принтере

    interface IDrawable
    {
        void DrawSquare(Square xSquare);
        void DrawCircle(Circle xCircle);
        void DrawTriangle(Triangle xTriangle);
    }
    class Drawable : IDrawable
    {
        void IDrawable.DrawCircle(Circle xCircle)
        {
            Console.SetCursorPosition(xCircle.position.x - 1, xCircle.position.y - 2);
            Console.Write("###");
            Console.SetCursorPosition(xCircle.position.x - 1, xCircle.position.y + 1);
            Console.Write("###");
            Console.SetCursorPosition(xCircle.position.x - 2, xCircle.position.y - 1);
            Console.Write("#");
            Console.SetCursorPosition(xCircle.position.x - 2, xCircle.position.y);
            Console.Write("#");
            Console.SetCursorPosition(xCircle.position.x + 2, xCircle.position.y - 1);
            Console.Write("#");
            Console.SetCursorPosition(xCircle.position.x + 2, xCircle.position.y);
            Console.Write("#");
        }
        void IDrawable.DrawSquare(Square xSquare)
        {
            Console.SetCursorPosition(xSquare.position.x, xSquare.position.y);
            Console.Write("###");
            Console.SetCursorPosition(xSquare.position.x, xSquare.position.y+1);
            Console.Write("###");
            Console.SetCursorPosition(xSquare.position.x, xSquare.position.y+2);
            Console.Write("###");
        }
        void IDrawable.DrawTriangle(Triangle xTriangle)
        {
            Console.SetCursorPosition(xTriangle.position.x, xTriangle.position.y);
            Console.Write("#");
            Console.SetCursorPosition(xTriangle.position.x, xTriangle.position.y + 1);
            Console.Write("##");
            Console.SetCursorPosition(xTriangle.position.x, xTriangle.position.y + 2);
            Console.Write("###");
        }
    }
    interface IPrintable : IDrawable
    {
    }
    class Printable : IPrintable
    {
        void IDrawable.DrawCircle(Circle xCircle)
        {
            StreamWriter sw = new StreamWriter("testfile.txt");
            sw.WriteLine(" ### ");
            sw.WriteLine("#   #");
            sw.WriteLine("#   #");
            sw.WriteLine(" ### ");
            sw.Close();

        }
        void IDrawable.DrawSquare(Square xSquare)
        {
            StreamWriter sw = new StreamWriter("testfile.txt");
            sw.WriteLine("###");
            sw.WriteLine("###");
            sw.WriteLine("###");
            sw.Close();
        }
        void IDrawable.DrawTriangle(Triangle xTriangle)
        {
            StreamWriter sw = new StreamWriter("testfile.txt");
            sw.WriteLine("#");
            sw.WriteLine("##");
            sw.WriteLine("###");
            sw.Close();
        }
    }
}

