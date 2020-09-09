namespace SoftNetTraining
{
    public class Circle
    {
        public static readonly double PI = 3.14;

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double calculateArea()
        {
            return PI * radius * radius;
        }
    }
}