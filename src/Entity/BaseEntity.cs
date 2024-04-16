

namespace library_management.src
{
    public class BaseEntity
    {
        public Guid Id { get; }
        public DateTime CreatedAt;


        public BaseEntity(DateTime? dateValue = null)
        {
            Id = Guid.NewGuid();
            CreatedAt = (DateTime)(dateValue == null ? DateTime.Now : dateValue);
        }
    }

}
// var people1 = new People("abc")


// now , inside people1 : there will be name: abc , _id: 20241504