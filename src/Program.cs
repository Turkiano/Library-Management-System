using library;
using library_management.src;
using library_management.src.Manager;

internal class Program
{

    private static void Main()
    {
        Library library = new Library("Jarir");
        User user = new("abc");
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book19 = new Book("The Iliad");
        Console.WriteLine(user.getName());

        Guid id = user.Id;
        library.AddUser(user);
        library.AddUser(user1);
        library.AddBookr(book1);
        library.AddBookr(book19);

        library.SortByDate(SortOrder.ASC).ToList().ForEach(book =>   //testing sort by date
        {
            Console.WriteLine($"Name: {book.getTitle()} - {book.CreatedAt}");

        });
        Console.WriteLine($"this is the id: {user.Id} and created at {user.CreatedAt}");
        Console.WriteLine($"User counter is: {library.GetUsersCurentVolume()}");
        Console.WriteLine($"Book counter is: {library.GetBooksCurentVolume()}");


        int page = 1;
        int usersPerPage = 1;
        int currentPage = (page - 1) * usersPerPage;
        var paginated = library.GetUser().Skip(currentPage).Take(usersPerPage);

        foreach (var newuser in paginated)
        {
            Console.WriteLine($"this is the id: {newuser.Id} and created at {newuser.CreatedAt}");
        }


    }





}
