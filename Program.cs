using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon square = new Square(3);
            Polygon rectangle = new Rectangle(2, 3);
            System.Console.WriteLine(square.Area);
            System.Console.WriteLine(rectangle.Area);
        }
    }

    abstract class Polygon
    {
        public double Height { get; }
        public double Width { get; }
        public abstract double Area { get; }
        public Polygon(double height, double width)
        {
            Height = height;
            Width = width;
        }
        
    }
    class Square : Polygon
    {
        public override double Area 
        { 
            get 
            {
                return Height * Width;
            }
        }
        public Square(double side) : base(side, side) 
        {
        }
    }
    class Rectangle : Polygon
    {
        public override double Area 
        {
            get
            {
                return Height * Width;
            }
        }
        public Rectangle(double height, double width) : base(height, width)
        {
        }
    }
}
