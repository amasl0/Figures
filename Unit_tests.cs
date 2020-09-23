using Xunit;
using Main;

namespace ConsoleApp1
{
    public class Unit_tests
    {
        public void Run()
        {
            test_isCircle();
            test_isTriangle();
            testCircleArea();
            testTriangleArea();
            TestRect();
        }
        [Fact]
        public void test_isCircle()
        {
            Circle fig = new Circle(8);
            Assert.Equal("Circle", fig.getName());
        }

        [Fact]
        public void test_isTriangle()
        {
            Triangle fig = new Triangle(10, 6, 8);
            Assert.Equal("Triangle", fig.getName());
        }

        [Fact]
        public void testTriangleArea()
        {
            Figure fig = new Triangle(10, 6, 8);
            Assert.Equal(24, fig.getArea());
        }

        public void testCircleArea()
        {
            Figure fig = new Circle(10);
            Assert.Equal(314.1592653589793, fig.getArea());
        }

        [Fact]
        public void TestRect()
        {
            Triangle fig = new Triangle(10, 6, 8);
            Assert.Equal(true, fig.isRectangular());
        }

    }
}
