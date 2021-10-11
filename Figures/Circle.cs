using System;

namespace Figures
{
    public class Circle : Figure
    {
        protected double radius;

        public Circle(double r)
        {
            if(r > 0)
            {
                radius = r;
            }else
            {
                Console.WriteLine("Negative radius is impossible");
            }
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
