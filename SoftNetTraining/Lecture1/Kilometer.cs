namespace SoftNetTraining.Lecture1
{
    public class Kilometer
    {
        public double Distance { get; }

        public Kilometer(double distance)
        {
            Distance = distance;
        }

        public Mile Convert()
        {
            return new Mile(Distance/1.6);
        }

        public static implicit operator Meter(Kilometer kilometer)
        {
            double m = kilometer.Distance * 1000;
            Meter meter = new Meter(m);
            return meter;
        }
        //
        // public static explicit operator double(Kilometer kilometer)
        // {
        //     return kilometer.Distance;
        // }
    }
}