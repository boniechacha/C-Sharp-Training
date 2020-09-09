using System.ComponentModel.Design;

namespace SoftNetTraining
{
    public struct Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }

            set { x = value; }
        }

        public int Y
        {
            get { return y; }

            set { y = value; }
        }

        public Point(int x, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static Point Create(int x = 0, int y = 0)
        {
            return new Point(x, y);
        }
    }
}