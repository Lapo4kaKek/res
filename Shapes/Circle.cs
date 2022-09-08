namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; private set;}
        public Circle(double radius, string typeName = "круг") : base(typeName)
        {
            if (IsExist(radius)) Radius = radius;
            else
            {
                throw new Exception("У круга не может быть отрицательный радиус");
            }
        }

        private static bool IsExist(double radius)
        {
            return !(radius < 0);
        }
        public override double Perimeter()
        {
            return 2*Math.PI*Radius;
        }

        public override double Square()
        {
            return Math.PI*Radius*Radius;
        }

        public override string ToString()
        {
            return $"{base.ToString()} с радиусом длины {Radius}";
        }
    }
}