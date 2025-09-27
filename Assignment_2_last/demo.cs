using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class BaseCls
    {
        public BaseCls(int number)
        {
            Console.WriteLine($"Base Class Constructor: {number}");
        }
    }

    internal class DerivedCls : BaseCls
    {
        public DerivedCls(int number) : base(number)
        {
            Console.WriteLine($"Derived Class Constructor: {number}");
        }
    }

    // Abstract class Shape
    internal abstract class Shape
    {
        public abstract  double CalculateArea();
    }

    // Circle class
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Triangle class
    internal class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }
    }


}

