

namespace library_management
{
    public interface INotificationService
    {

        public void SendNotificationOnSucess(string message);
        public void SendNotificationOnFailure(string message);


    }
}