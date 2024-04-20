

namespace library_management
{
    public class EmailNotificationService : INotificationService

    {
        public void SendNotificationOnSucess(string message)
        {
            string sucessMessage = $"Hello, a new {message} has been successfully added to the Library.";
            Console.WriteLine(sucessMessage);
            File.AppendAllText("emailLog.txt", $"Date:{DateTime.Now} - {sucessMessage} \n\n");
        }
        public void SendNotificationOnFailure(string message)
        {
            string failureMessage = $"Hello, This is a warning {message} has not been added to the Library.";
            Console.WriteLine(failureMessage);
            File.AppendAllText("emailLog.txt", $"Date:{DateTime.Now} - {failureMessage} \n\n");
        }
    }
}