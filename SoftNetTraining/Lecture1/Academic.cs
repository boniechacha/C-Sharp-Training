namespace SoftNetTraining
{
    public class Academic
    {
        private BookDatabase _bookDatabase;

        public Academic()
        {
            _bookDatabase = BookDatabase.getInstance();
        }
    }
}