

namespace library_management.src
{
    public class Book : BaseEntity
    {
        private string _title; //property
        //public string Type; //property

        public Book(string title, DateTime? dateValue = null) : base(dateValue)//constructor
        {
            _title = title;
        }

        public string getTitle() //Get method for privacy
        {
            return _title;
        }


    }
}