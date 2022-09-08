using Shapes;

namespace ShapeTests
{
    public class UnitTestTriangle
    {
        [Fact]
        public void Checking_Perimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(12, triangle.Perimeter());
        }

        [Fact]
        public void Checking_Square()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.Square());
        }
        [Fact]
        public void Is_Rectangular()
        {
            Triangle triangle = new Triangle(6, 10, 8);
            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void Is_No_Rectangular()
        {
            Triangle triangle = new Triangle(5, 15, 11);
            Assert.False(triangle.IsRectangular());
        }

        [Fact]
        public void Checking_Throwing_Exception()
        {
            var result = Assert.Throws<Exception>(() => new Triangle( 2, 1, 1));
            Assert.Equal("Такого треугольника не сущетсвует", result.Message);
        }
        [Fact]
        public void Checking_Throwing_Exception_Create_Negative_Side()
        {
            var result = Assert.Throws<Exception>(() => new Triangle(-1, 6, 7));
            Assert.Equal("Такого треугольника не сущетсвует", result.Message);
        }
        [Fact]
        public void Checking_ToString()
        {
            Triangle triangle = new Triangle(5, 15, 11);
            Assert.Equal("Я - треугольник со сторонами длины 5, 15, 11",  triangle.ToString());
        }
        [Fact]
        public void Create_Triangle_Using_Link_Abstract()
        {
            Shape triangle = new Triangle( 3, 4, 5);
            Assert.Equal(12, triangle.Perimeter());
        }

        [Fact]
        public void Checking_Wrong_ToString()
        {
            Triangle triangle = new Triangle(5, 15, 11);
            Assert.NotEqual("Я - круг",  triangle.ToString());
        }
        
    }
}