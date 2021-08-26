using System;
using System.Collections.Generic;
using MagazynierApp.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace MagazynierApp.Server
{
    public class MachineNotificationManager: INotificationManager
    {
        private List<MachineNotification> _machineNotifications;
        
        public void AddNotification(INotification notification)
        {
            Console.WriteLine("Notification added");
        }
        public void SendNotification()
        {
            Console.WriteLine("Notification send");
        }
    }
}
