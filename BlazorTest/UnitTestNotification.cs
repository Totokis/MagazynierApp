using System;
using System.Collections.Generic;
using MagazynierApp.Shared;
using NUnit.Framework;

namespace BlazorTest
{
    public class UnitTestNotification
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGeneratingNotifications()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            Assert.Greater(notification1.ProductsToRefill.Count, 0);
        }
        
        [Test]
        public void CheckTwoNotificationsEquals()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);

            Assert.True(Equals(notification1, notification2));
        }
        
        [Test]
        public void CheckTwoNotificationsNotEquals_Because_Time()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);
            notification2.AlertTime = notification2.AlertTime.AddHours(3);

            Assert.False(Equals(notification1, notification2));
        }
        [Test]
        public void CheckTwoNotificationsNotEquals_Because_Name()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);
            notification2.MachineName = "Test";

            Assert.False(Equals(notification1, notification2));
        }
        
        [Test]
        public void CheckTwoNotificationsNotEquals_Because_DistributionPoint()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);
            notification2.DistributionPoint = "Test";

            Assert.False(Equals(notification1, notification2));
        }
        
        [Test]
        public void CheckTwoNotificationsNotEquals_Because_Products()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsTypeEmpty_500;
            var notification1 = new MachineWarningNotification(machine);
            var notification2 = new MachineWarningNotification(machine);
            notification2.ProductsToRefill = Product.ListOfProductsType1_500;

            Assert.False(Equals(notification1, notification2));
        }

        
    }
}
