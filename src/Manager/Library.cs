

using library;

namespace library_management.src.Manager
{
    public class Library
    {
        private String _name;
        private IEnumerable<User> _users;
        private IEnumerable<Book> _books = [];

        public Library(String name)
        {
            _name = name;
            _users = [];
            _books = [];
        }

        public IEnumerable<Book> GetBooks()
        {

            return _books;
        }
        public IEnumerable<Book> GetBooks(int page)
        {
            // implement pagination...
            return _books;
        }
        public void AddUser(User user)
        {
            _users = _users.Append(user);
        }

        public void AddBookr(Book book)
        {
            _books = _books.Append(book);
        }

        public IEnumerable<User> GetUser() //this is the get method for User
        {
            return _users;
        }

        public int GetUsersCurentVolume()
        {
            int totalAmount = 0;
            foreach (User user in _users)
            {
                totalAmount++;
            }
            return totalAmount;
        }
        public int GetBooksCurentVolume()
        {
            int totalAmount = 0;
            foreach (Book book in _books)
            {
                totalAmount++;
            }
            return totalAmount;
        }

        public IEnumerable<Book> SortByDate(SortOrder order)//method for sorting by date
        {
            if (order == SortOrder.DESC)
            {

                return _books.OrderByDescending(book => book.CreatedAt);
            }
            if (order == SortOrder.ASC)
            {

                return _books.OrderBy(book => book.CreatedAt);
            }

            return _books;
        }




    }
}


