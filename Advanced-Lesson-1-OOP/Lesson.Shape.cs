using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public static partial class Lesson
    {

        public static void AbstractionShapeExample()
        {
            IShape[] shapes = new IShape[]
            {
                new Rectangle(10, 10),
                new Circle(5),
                new Circle(12)
            };

            Print(shapes);
        }

        public static void Print(params IShape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

    }

    public interface IShape                     //A.L1.P1/6. Square Matrix
    {
        int Draw();
    }

    class Rectangle : IShape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Draw()
        {
            return width*height;
        }
    }


    class Circle : IShape
    {
        private int rad;

        public Circle(int rad)
        {
            this.rad = rad;
        }

        public int Draw()
        {
            return  (int)(Math.PI*rad*rad);
        }
    }


    public class Triangle : IShape
    {
        private int baseTriangle;
        private int height;

        public Triangle(int baseTriangle, int height)
        {
            this.baseTriangle = baseTriangle;
            this.height = height;
        }

        public int Draw()
        {
            return baseTriangle * height / 2;
        }
    }

}
