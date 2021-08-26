using MagazynierApp.Shared;

namespace MagazynierApp.Server
{
    public interface INotificationManager
    {
        void AddNotification(INotification notification);
        void SendNotification();
    }
}
