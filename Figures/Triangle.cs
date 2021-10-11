using System;

namespace Figures
{
    public class Triangle : Figure
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double _a, double _b, double _c)
        {
            bool possible = checkSides(_a, _b, _c);

            if(possible)
            {
                a = _a;
                b = _b;
                c = _c;
            }else 
            {
                Console.WriteLine("impossible triangle sides");
            }
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }

        public override double GetSquare()
        {
            double p = this.GetPerimeter()/2;

            return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        }

        public bool checkSides(double a, double b, double c)
        {
            if(0 >= a || 0 >= b || 0 >= c) return false;

            if(a >= b + c  || b >= a + c  || c >= a + b) return false;

            return true;
        }
    }
}
