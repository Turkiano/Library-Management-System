

namespace library_management.src
{
    public class User : BaseEntity
    {
        private string _name; // properties

        public User(string name, DateTime? dateValue = null) : base(dateValue) // constructor
        {
            _name = name;
        }
        public string getName() //Get method for privacy
        {
            return _name;
        }
    }
}