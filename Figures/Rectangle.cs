using System;

namespace Figures
{
    public class Rectangle : Figure
    {
        protected double width;
        protected double length;

        public Rectangle(double a, double b)
        {
            if(a > 0 && b > 0)
            {
                width = a;
                length = b;
            }else
            {
                Console.WriteLine("Wrong sides");
            }
        }

        public override double GetPerimeter()
        {
            return 2*(width + length);
        }

        public override double GetSquare()
        {
            return length * width;
        }
    }
}
