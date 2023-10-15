using SquareMeter;

namespace UnitTestSquare
{
    public class CircleTests
    {
        //accuracy constant to remove errors from double squaring
        private double unitTestPrecision = 1e-5;

        private double CalculateExpectedSquareOfCircle(double radius)
        {
            if (radius <= 0)
            {
                return 0;
            }
            else
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleSquareTest1()
        {
            var radius = 1000;
            var circle = new Circle(radius);
            var squareCircle = circle.GetSquareOfCircleByRadius();
            var expectedValue = CalculateExpectedSquareOfCircle(radius);
            Assert.True(Math.Abs(squareCircle - expectedValue)< unitTestPrecision);
        }
        [Test]
        public void CircleSquareTest2()
        {
            var radius = 0;
            var circle = new Circle(radius);
            var squareCircle = circle.GetSquareOfCircleByRadius();
            var expectedValue = CalculateExpectedSquareOfCircle(radius);
            Assert.True(Math.Abs(squareCircle - expectedValue) < unitTestPrecision);
        }
        [Test]
        public void CircleSquareTest3()
        {
            var radius = -1000;
            var circle = new Circle(radius);
            var squareCircle = circle.GetSquareOfCircleByRadius();
            var expectedValue = CalculateExpectedSquareOfCircle(radius);
            Assert.True(Math.Abs(squareCircle - expectedValue) < unitTestPrecision);
        }
    }
}