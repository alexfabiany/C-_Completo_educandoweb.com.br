using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type.ToString().ToUpper() == "R")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, height, width));
                }
                else if (type.ToString().ToUpper() == "C")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine($"{shape.Color} " +
                    $"{((shape is Rectangle)?"Rectangle":"Circle")}: " +
                    $"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.ReadKey();
        }
    }
}
