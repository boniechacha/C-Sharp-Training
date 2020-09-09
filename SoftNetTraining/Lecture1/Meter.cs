namespace SoftNetTraining.Lecture1
{
    public class Meter
    {
        public double Distance { get; }

        public Meter(double distance)
        {
            this.Distance = distance;
        }

        public static explicit operator double(Meter m)
        {
            return m.Distance;
        }
    }
}