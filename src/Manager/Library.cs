

namespace library_management.src.Manager
{
    public class Library
    {
        private IEnumerable<User> _users = [];
        private IEnumerable<Book> _books = [];

        

        public void AddUser(User user){
           _users = _users.Append(user);
        }

         public void AddBookr(Book book){
           _books = _books.Append(book);
        }
        
    }
}