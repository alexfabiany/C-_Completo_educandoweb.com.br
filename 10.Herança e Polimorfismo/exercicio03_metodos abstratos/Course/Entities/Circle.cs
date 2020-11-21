using System;
using Course.Enums;

namespace Course.Entities
{
    class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
