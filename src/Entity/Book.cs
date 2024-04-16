

namespace library_management.src
{
    public class Book : BaseEntity
    {
        private string _title; //property
        public string Type; //property

        public Book(string title, string type) //constructor
        {
            _title = title;
            Type = type;
        }

        public string gettitle() //Get method for privacy
        {
            return _title;
        }


    }
}