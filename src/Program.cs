using library_management.src;

internal class Program
{

    private static void Main()
    {

        User user = new("abc");
        Console.WriteLine(user.getName());

        User id = new();
        Console.WriteLine($"this is the id: {user.Id}");


    }





}
