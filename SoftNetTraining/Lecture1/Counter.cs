namespace SoftNetTraining
{
    public class Counter
    {
        private int count;

        public int Count { get; }

        public void increment(int input = 1)
        {
            count = count + 1;
        }

        /**
         * Private Constructor
         */
        private Counter()
        {
        }

        /**
         * Factory method
         */
        public static Counter Create()
        {
            return new Counter();
        }
    }
}