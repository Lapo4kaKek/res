using Shapes;
using Xunit.Sdk;

namespace ShapeTests
{
    public class UnitTestCircle
    {
        [Fact]
        public void First_Checking_Square()
        {
            Circle circle = new Circle(3);
            Assert.Equal(28.27, Math.Round(circle.Square(), 2));
        }

        [Fact]
        public void Second_Checking_Square()
        {
            Circle circle = new Circle(10.77);
            Assert.Equal(364.40, Math.Round(circle.Square(), 2));
        }

        [Fact]
        public void First_Checking_Perimeter()
        {
            Circle circle = new Circle(4);
            Assert.Equal(25.13, Math.Round(circle.Perimeter(), 2));
        }
        [Fact]
        public void Second_Checking_Perimeter()
        {
            Circle circle = new Circle(777);
            Assert.Equal(4882.03, Math.Round(circle.Perimeter(), 2));
        }

        [Fact]
        public void Checking_Throwing_Exception_Create_Negative_Radius()
        {
            var result = Assert.Throws<Exception>(() => new Circle(-3));
            Assert.Equal("У круга не может быть отрицательный радиус", result.Message);
        }

        [Fact]
        public void Checkin_ToString()
        {
            Circle circle = new Circle(1);
            Assert.Equal("Я - круг с радиусом длины 1", circle.ToString());
        }
        [Fact]
        public void Checkin_Wrong_ToString()
        {
            Circle circle = new Circle(1);
            Assert.NotEqual("Я - треугольник", circle.ToString());
        }

        [Fact]
        public void Create_Circle_Using_Link_Abstract()
        {
            Shape circle = new Circle(1);
            Assert.NotNull(circle);
        }
    }
}