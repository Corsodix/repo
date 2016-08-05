using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.WindowWidth;
            //Console.SetBufferSize(80, 25);


            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();


            //Point p1 = new Point(1,3,'*');
            //p1.Draw();

            //Point p2 = new Point(4,5,'#');
            //p2.Draw();

            //List<Point> pList = new List<Point>();
            //pList.Add(p1);
            //pList.Add(p2);

            //HorizontalLine line = new HorizontalLine(5, 10, 8, '+' );
            //line.DrawLine();

            //VerticalLine vLine = new VerticalLine(8, 15, 10,'+');
            //vLine.DrawLine();

            Console.ReadKey();
        }
    }


}
