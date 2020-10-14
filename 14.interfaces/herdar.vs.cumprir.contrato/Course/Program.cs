using System;
using Course.Model.Entities;
using Course.Model.Enums;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Shape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            Shape s2 = new Rectangle() { Width = 3.3, Height = 5.8, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
