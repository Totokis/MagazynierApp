using MagazynierApp.Shared;
using NUnit.Framework;

namespace BlazorTest
{
    public class MachineTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SettingMinimalCapacity()
        {
            var machine = new Machine();
            machine.Capacity = 0;
            Assert.GreaterOrEqual(machine.Capacity, Machine.MinCapacity);
        }
        
        [Test]
        public void SettingMaximalCapacity()
        {
            var machine = new Machine();
            machine.Capacity = 0;
            Assert.LessOrEqual(machine.Capacity, Machine.MaxCapacity);
        }
        
        [Test]
        public void SettingCapacity()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            Assert.AreEqual(400, machine.Capacity);
        }

        [Test]
        public void SettingMoreProductsThanCapacity()
        {
            var machine = new Machine();
            machine.Capacity = 400;
            machine.ProductsList = Product.ListOfProductsType1_500;
            Assert.LessOrEqual(machine.CurrentNumberOfProducts,machine.Capacity);
            
        }
        
    }
}
