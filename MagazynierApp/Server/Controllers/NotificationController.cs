using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using MagazynierApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebPush;

namespace MagazynierApp.Server.Controllers
{
    [Route("notifications")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly VapidConfiguration _vapidConfiguration;
        public static List<NotificationSubscription> SubscriptionsStorage = new List<NotificationSubscription>();

        public NotificationController(IOptions<VapidConfiguration> vapidConfiguration)
        {
            _vapidConfiguration = vapidConfiguration.Value;
        }
        
        
        [HttpPut("subscribe")]
        public async void Subscribe(NotificationSubscription subscription)
        {
            var userId = GetUserId();
            foreach (var notificationSubscription in SubscriptionsStorage.ToArray())
            {
                if (notificationSubscription.UserId == userId)
                    SubscriptionsStorage.Remove(notificationSubscription);
            }
            subscription.UserId = userId;
            SubscriptionsStorage.Add(subscription);
            Console.WriteLine("Subscription Added !");
            await SendNotificationToAll();
           

        }
        private async Task SendNotificationToAll()
        {
            foreach (var subscription in SubscriptionsStorage)
            {
                await SendNotificationAsync(subscription);
            }
            await SendNotificationToAll();
        }

        private async Task SendNotificationAsync(NotificationSubscription subscription)
        {
            await Task.Delay(10_000);
            string message = "Otrzymałeś testowe powiadomienie, które zostanie wysłane ponownie za 10 sekund !";
            var publicKey = _vapidConfiguration.PublicKey;
            var privateKey = _vapidConfiguration.PrivateKey;

            var pushSubscription = new PushSubscription(subscription.Url, subscription.P256dh, subscription.Auth);
            var vapidDetails = new VapidDetails(_vapidConfiguration.Subject, publicKey, privateKey);
            var webPushClient = new WebPushClient();
            try
            {
                var payload = JsonConvert.SerializeObject(new {message });
                await webPushClient.SendNotificationAsync(pushSubscription, payload, vapidDetails);
                Console.WriteLine("Notification send");
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error sending push notification: "+ e.Message);
            }
        }
        
        private string GetUserId()
        {
            return HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
