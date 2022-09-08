using System.Collections.Generic;
using System.Collections.Immutable;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; private set;}
        public double SideB { get; private set;}
        public double SideC { get; private set;}

        public Triangle(double a, double b, double c, string typeName="треугольник") : base(typeName)
        {
            if (IsExist(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
            {
                throw new Exception("Такого треугольника не сущетсвует");
            }
        }

        public bool IsRectangular()
        {
            double[] sides  = {SideA, SideB, SideC};
            Array.Sort(sides);
            if (sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2] == 0) return true;
            return false;
        }
        private static bool IsExist(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0) return true;
            return false;
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double Square()
        {
            double halfPerimeter = Perimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public override string ToString()
        {
            return $"{base.ToString()} со сторонами длины {SideA}, {SideB}, {SideC}";
        }
    }
}