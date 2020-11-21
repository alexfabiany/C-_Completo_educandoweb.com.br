using Course.Enums;

namespace Course.Entities
{
    class Rectangle: Shape
    {
        public double Height { get; private set; }
        public double Width { get; private set; }

        public Rectangle(Color color, double height, double width) : base (color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
