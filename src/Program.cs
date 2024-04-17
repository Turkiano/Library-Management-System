using library_management.src;

internal class Program
{

    private static void Main()
    {

        User user = new("abc");
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book19 = new Book("The Iliad");
        Console.WriteLine(user.getName());

        Guid id = user.Id;

        Console.WriteLine($"this is the id: {user.Id}");


    }





}
