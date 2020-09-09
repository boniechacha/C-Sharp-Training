namespace SoftNetTraining
{
    public class Library
    {
        private BookDatabase _bookDatabase;

        public Library()
        {
            _bookDatabase = BookDatabase.getInstance();
        }
    }
}