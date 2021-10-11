using System;

namespace Figures
{
    public class Square : Figure
    {
        protected double side;

        public Square(double a)
        {
            if(a > 0)
            {
                side = a;
            }else
            {
                Console.WriteLine("Negative side is impossible");
            }
        }

        public override double GetPerimeter()
        {
            return 4*side;
        }

        public override double GetSquare()
        {
            return side * side;
        }
    }
}
