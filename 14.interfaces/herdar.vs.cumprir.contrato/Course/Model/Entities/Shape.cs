using Course.Model.Enums;
using System.Collections.Generic;
using System.Text;

namespace Course.Model.Entities {
    abstract class Shape {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
