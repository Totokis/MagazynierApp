using System.Linq;
using MagazynierApp.Shared;
using NUnit.Framework;

namespace BlazorTest
{
    public class ProductTest
    {
        [Test]
        public void CheckMinQuantity()
        {
            var listOfProducts = Product.ListOfProductsType1_500;
            
            Assert.AreEqual(0,listOfProducts.First().MinQuantity);
        }
    }
}
