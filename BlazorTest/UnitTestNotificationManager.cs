using MagazynierApp.Server;
using MagazynierApp.Shared;
using NUnit.Framework;

namespace BlazorTest
{
    public class UnitTestNotificationManager
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NoDoubleNotifcation()
        {
            var manager = new MachineNotificationManager(null);
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);
            
            manager.AddNotification(notification1);
            manager.AddNotification(notification2);
            
            Assert.AreEqual(1,manager.MachineNotifications.Count);
            
        }
    }
}
