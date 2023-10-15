namespace SquareMeter
{
    public class Triangle
    {
        //triangle sides
        double a { get; }
        double b { get; }
        double c { get; }
        private double halfPerimeter;
        //accuracy constant to remove errors from double squaring
        private double accuracyConstant = 1e-5;
        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetSquareOfTriangleBySides()
        {
            if (a <= 0 | b <= 0 | c <= 0)
            {
                return 0;
            }
            else
            {
                halfPerimeter = (a + b + c) / 2;
                //return square of triangle
                return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }

        }
        public bool IsTriangleRight()
        {
            //Find longest side, return square
            if (a <= 0 | b <= 0 | c <= 0)
            {
                return false;
            }
            else if (Math.Max(Math.Max(a, b), Math.Max(b, c)) == a)
            {
                return Math.Abs(Math.Pow(a, 2)- Math.Pow(b, 2) - Math.Pow(c, 2))<accuracyConstant;
            }
            else if (Math.Max(Math.Max(a, b), Math.Max(b, c)) == b)
            {
                return Math.Abs(Math.Pow(b, 2) - Math.Pow(a, 2) - Math.Pow(c, 2)) < accuracyConstant;
            }
            else
            {
                return Math.Abs(Math.Pow(c, 2) - Math.Pow(b, 2) - Math.Pow(a, 2)) < accuracyConstant;
            }
        }
    }
}