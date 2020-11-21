using Course.Enums;

namespace Course.Entities
{
    abstract class Shape
    {
        public Color Color { get; private set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
