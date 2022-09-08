namespace Shapes
{
    public abstract class Shape
    {
        public string TypeName { get; private set;}

        protected Shape(string typeName)
        {
            TypeName = typeName;
        }

        public abstract double Perimeter();
        public abstract double Square();
        public override string ToString()
        {
            return $"Я - {TypeName}";
        }
    }
}
