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
            //Turtle.Speed = 4;

            GraphicsWindow.BrushColor = "Red";
            var food = Shapes.AddRectangle(10,10);

            var xFood = 320;
            var yFood = 200;
            Shapes.Move(food, xFood, yFood);

            Random rand = new Random();


            while (true)
            {
                Turtle.Move(10);
                if (Turtle.X >= xFood && Turtle.X <= xFood+10 && Turtle.Y >= yFood && Turtle.Y <= yFood+10)
                {
                    xFood = rand.Next(0, GraphicsWindow.Width);
                    yFood = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(food, xFood, yFood);
                    Turtle.Speed++;
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
