using SquareMeter;

namespace UnitTestSquare
{
    public class TriangleTests
    {
        //accuracy constant to remove errors from double squaring
        private double unitTestPrecision = 1e-5;
        private double halfPerimeter;

        private double calculateExpectedSquareOfTriangle(double a, double b, double c)
        {
            
            if (a <= 0 | b <= 0 | c <= 0)
            {
                return 0;
            }
            else
            {
                halfPerimeter = (a + b + c) / 2;
                //return square of triangle
                return Math.Sqrt(halfPerimeter* (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleSquareTest1()
        {
            var a = 5;
            var b = 4;
            var c = 3;
            var triangle = new Triangle(a,b,c);
            var squareTriangle = triangle.GetSquareOfTriangleBySides();
            var expectedValue = calculateExpectedSquareOfTriangle(a,b,c);
            Assert.True(Math.Abs(squareTriangle - expectedValue)< unitTestPrecision);
        }
        [Test]
        public void TriangleSquareTest2()
        {
            var a = 5;
            var b = -4;
            var c = -3;
            var triangle = new Triangle(a, b, c);
            var squareTriangle = triangle.GetSquareOfTriangleBySides();
            var expectedValue = calculateExpectedSquareOfTriangle(a, b, c);
            Assert.True(Math.Abs(squareTriangle - expectedValue) < unitTestPrecision);
        }
        [Test]
        public void TriangleRightTest1()
        {
            var a = 1;
            var b = 1;
            var c = 1;
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsTriangleRight();
            var expectedValue = false;
            Assert.That(isRightTriangle, Is.EqualTo(expectedValue));
        }
        [Test]
        public void TriangleRightTest2()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsTriangleRight();
            var expectedValue = true;
            Assert.That(isRightTriangle, Is.EqualTo(expectedValue));
        }
        [Test]
        public void TriangleRightTest3()
        {
            var a = 25;
            var b = 7;
            var c = 24;
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsTriangleRight();
            var expectedValue = true;
            Assert.That(isRightTriangle, Is.EqualTo(expectedValue));
        }
        [Test]
        public void TriangleRightTest4()
        {
            var a = -25;
            var b = 7;
            var c = 24;
            var triangle = new Triangle(a, b, c);
            var isRightTriangle = triangle.IsTriangleRight();
            var expectedValue = false;
            Assert.That(isRightTriangle, Is.EqualTo(expectedValue));
        }
    }
}