using System;

namespace Figures
{
    public class Rhombus : Figure
    {
        public double DefaultAngle = 0.523;
        protected double side;
        protected double angle;

        public Rhombus(double a, double alpha) 
        {
            if(a > 0 && alpha > 0 && alpha < Math.PI)
            {
                side = a;
                angle = alpha;
            }else
            {
                Console.WriteLine("Wrong parameters");
            }
        }
        public Rhombus(double a)
        {
            if(a > 0)
            {
                side = a;
                angle = DefaultAngle;
            }
        }

        public override double GetPerimeter()
        {
            return 4*side;
        }

        public override double GetSquare()
        {
            return side * side * Math.Sin(angle);
        }
    }
}
