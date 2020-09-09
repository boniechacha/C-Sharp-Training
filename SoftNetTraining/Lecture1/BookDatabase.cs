namespace SoftNetTraining
{
    public class BookDatabase
    {

        private static BookDatabase _bookDatabase;

        private BookDatabase()
        {
        }
        public static BookDatabase getInstance()
        {
            if (_bookDatabase == null)
            {
                _bookDatabase = new BookDatabase();
            }

            return _bookDatabase;
        }
        
        public void save(int id, Book book)
        {
            
        }
        
        public void delete(int id)
        {
            
        }

        public Book[] getAll()
        {
            return new Book[10];
        }
    }
}