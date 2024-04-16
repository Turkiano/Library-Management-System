

namespace library_management.src.Manager
{
    public class Library
    {
        private IEnumerable<User> _users = [];

        public void AddUser(User user){
            _users.Append(user);
        }
        
    }
}