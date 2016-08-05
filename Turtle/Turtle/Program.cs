using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            Turtle.Speed = 4;

            GraphicsWindow.BrushColor = "Red";
            var food = Shapes.AddRectangle(10,10);

            var xFood = 320;
            var yFood = 200;
            Shapes.Move(food, xFood, yFood);

            while (true)
            {
                Turtle.Move(10);

                int x = Turtle.X;
                int y = Turtle.Y;

                Shapes.Move(food, xFood, yFood);

                if (x - xFood <= 10 && y - yFood <= 10 && x - xFood >= -10 && y - yFood >= -10)
                {
                    xFood = xFood + 20;
                }
            }
            



        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;

            }
            else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
