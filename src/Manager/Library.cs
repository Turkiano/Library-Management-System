



namespace library_management
{
    public class Library
    {
        private string _name;
        private IEnumerable<User> _users;
        private IEnumerable<Book> _books;

        private INotificationService _loggerEmail;
        private INotificationService _loggerSMS;


        public Library(string name, INotificationService loggerEmail, INotificationService loggerSMS)
        {
            _name = name;
            _users = [];
            _books = [];
            _loggerEmail = loggerEmail;
            _loggerSMS = loggerSMS;
        }

        public IEnumerable<Book> GetBooks()
        {

            return _books;
        }
        public IEnumerable<Book> GetBooks(int page) //overloading method
        {
            // implement pagination...
            return _books;
        }
        public void AddUser(User user)
        {
            _users = _users.Append(user);
            _loggerEmail.SendNotificationOnSucess($"User ({user.getName()})"); //to use it in the Email/SMS notification message (User)
            _loggerSMS.SendNotificationOnSucess($"User ({user.getName()})"); //to use it in the Email/SMS notification message (User)


        }

        public void AddBookr(Book book)
        {
            _books = _books.Append(book);
            _loggerEmail.SendNotificationOnSucess($"Book ({book.getTitle()})"); //to use it in the Email/SMS notification message (book)
            _loggerSMS.SendNotificationOnSucess($"Book ({book.getTitle()})"); //to use it in the Email/SMS notification message (book)
        }

        public IEnumerable<User> GetUser() //this is the get method for User
        {
            return _users;
        }

        public int GetUsersCurentVolume() //extra features from inventory system assignmet
        {
            int totalAmount = 0;
            foreach (User user in _users)
            {
                totalAmount++;
            }
            return totalAmount;
        }
        public int GetBooksCurentVolume() //extra features from inventory system assignmet
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


