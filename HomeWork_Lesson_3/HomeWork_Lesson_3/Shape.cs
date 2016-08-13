using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Lesson_3
{
    //4. * Реализовать базовый класс Shape и описать общие методы для работы с формами.Реализовать класс наследник от Shape: Triangle, Square, Circle.
    //    Каждый их этих классов должен переопределять метод вычисления площади.Должен быть переопределен метод ToString для всех классов(включая Shape),
    //    который должен выводить название текущего класса.Для треугольника так же можно попробовать реализовать наследников (Равнобедренный треугольник, 
    //    прямоугольный треугольник). Типы фигур можно задавать через enum.

    class Shape
    {
        public int edgeLength, edgeCount, radius;
        int s;
        public Position position;
        public string name;
        public struct Position
        {
            public int x, y;
            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Shape(Position position, string name)
        {
            this.name = name;
            this.position = position;
        }
        public virtual double Area()
        {
            return s;
        }
        public new string ToString()
        {
            return name;
        }
    }
    class Square : Shape
    {
        public Square(Position position, int edgeLength) : base (position, "Квадрат")
        {
            this.edgeLength = edgeLength;
            edgeCount = 4;
        }
        public override double Area()
        {
            return edgeLength*edgeLength; 
        }
        public new string ToString()
        {
            return name;
        }
    }
    class Circle : Shape
    {
        public Circle(Position position, int radius) : base(position, "Круг")
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI*Math.Sqrt(Convert.ToDouble(radius));
        }

        public new string ToString()
        {
            return name;
        }
    }
    class Triangle : Shape
    {
        public double angle;
        public int edge1, edge2;

        public Triangle(Position position, int edge1, int edge2, double angle) : base(position, "Треугольник")
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.angle = angle;
            edgeCount = 3;
        }
        public override double Area()
        {
            return (edge1*edge2*Math.Sin(angle * Math.PI / 180))/2;
        }

        public new string ToString()
        {
            return name;
        }
    }

}
