using System;
using System.Collections.Generic;
using System.Text;

namespace GUI2021_11_09
{
    public class Rect
    {
        private double width;
        private double height;
        public double Width { get { return width; } set { width = value; Area = CalcArea(); } }
        public double Height { get { return height; } set { height = value; Area = CalcArea(); } }



        public double Area {
            get;
            private set;
        }

        public double CalcArea()
        {
            return Width * Height;
        }

        public void Print()
        {
            Console.WriteLine($"Area of the rectangle is {CalcArea()}");
        }

        public Rect(double width,double height)
        {
            Width = width;
            Height = height;
            Area = CalcArea();
        }

        public Rect()
        {
            Width = 0;
            Height = 0;
            Area = 0;
        }

    
    }
}
