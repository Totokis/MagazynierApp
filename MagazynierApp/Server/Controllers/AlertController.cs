using System.Collections.Generic;
using MagazynierApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace MagazynierApp.Server.Controllers
{
    [Route("alerts")]
    [ApiController]
    public class AlertController: Controller
    {
        private INotificationManager _notificationManager;
        public AlertController(INotificationManager notificationManager)
        {
            _notificationManager = notificationManager;
        }

        [HttpGet]
        public List<MachineWarningNotification> GetAlerts()
        {
            var list = _notificationManager as MachineNotificationManager;
            return list.MachineNotifications;
        }
        
    }
}
