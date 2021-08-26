using System.Runtime.InteropServices.ComTypes;
using MagazynierApp.Shared;

namespace MagazynierApp.Server
{
    public static class SeedData
    {
        public static void Initialize(ApplicationStoreContext db)
        {
            var products = new[]
            {
                new Product() { Name = "Środki Ochrony pracy", Quantity = 100, MaxQuantity = 100, ImageUrl = "img/products/srodki-ochrony-pracy.jpg" },
                new Product() { Name = "Artykuły Ścierne i tnące", Quantity = 180, MaxQuantity = 200, ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg" },
                new Product() { Name = "Chemia Techniczna", Quantity = 40, MaxQuantity = 150, ImageUrl = "img/products/chemia-techniczna.jpg" },
                new Product() { Name = "Artykuły biurowe", Quantity = 30, MaxQuantity = 50, ImageUrl = "img/products/artykuly-biurowe.jpg" },
            };

            var machines = new[]
            {
                new Machine
                {
                    Id = 1,
                    Name = "D1080",
                    Localization = "Brembo",
                    Capacity = 500,
                    ImageUrl = "img/machines/D1080.png",
                    ProductsList = Product.ListOfProductsType1_500
                },
                new Machine
                {
                    Id = 2,
                    Name = "D540",
                    Localization = "KGHM",
                    Capacity = 600,
                    ImageUrl = "img/machines/D540.png",
                    ProductsList = Product.ListOfProductsTypeEmpty_500
                },
                new Machine
                {
                    Id = 3,
                    Name = "F80",
                    Localization = "Ekookna",
                    Capacity = 700,
                    ImageUrl = "img/machines/F80.png",
                    ProductsList = Product.ListOfProductsTypeFull_500
                },
                new Machine
                {
                    Id = 4,
                    Name = "L40",
                    Localization = "Tenneco",
                    Capacity = 800,
                    ImageUrl = "img/machines/L40.png",
                    ProductsList = Product.ListOfProductsType1_500
                },
                new Machine
                {
                    Id = 5,
                    Name = "D1080",
                    Localization = "Tenneco",
                    Capacity = 1000,
                    ImageUrl = "img/machines/D1080.png",
                    ProductsList = Product.ListOfProductsType1_500
                },
                new Machine
                {
                    Id = 6,
                    Name = "F80",
                    Localization = "Ekookna",
                    Capacity = 550,
                    ImageUrl = "img/machines/F80.png",
                    ProductsList = Product.ListOfProductsType1_500
                },
            };
            
            db.Products.AddRange(products);
            db.Machines.AddRange(machines);
            db.SaveChanges();
        }
    }
}
