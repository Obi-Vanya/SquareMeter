namespace SquareMeter
{
    public class Circle
    {
        double radius { get; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetSquareOfCircleByRadius()
        {
            if (radius <= 0)
            {
                return 0;
            }
            else
            {
                return Math.PI * Math.Pow(radius,2);
            }
            
        }
    }
}