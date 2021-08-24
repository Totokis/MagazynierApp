using System.Collections.Generic;

namespace MagazynierApp.Shared
{
    public class Product
    {
        public string Name { get; set; }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public int MaxQuantity
        {
            get => _maxQuantity;
            set => _maxQuantity = value;
        }

        public string ImageUrl { get; set; }

        private int _maxQuantity;
        private int _quantity;

        public static List<Product> ListOfProductsType1_500 = new List<Product>
        {
            new Product(){Name = "Środki Ochrony pracy",Quantity = 100, MaxQuantity = 100, ImageUrl = "img/products/srodki-ochrony-pracy.jpg"},
            new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 180,MaxQuantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            new Product(){Name = "Chemia Techniczna",Quantity = 40,MaxQuantity = 150,ImageUrl = "img/products/chemia-techniczna.jpg"},
            new Product(){Name = "Artykuły biurowe",Quantity = 5, MaxQuantity = 50,ImageUrl = "img/products/artykuly-biurowe.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
            // new Product(){Name = "Artykuły Ścierne i tnące",Quantity = 200,ImageUrl = "img/products/artykuly-scierne-i-tnace.jpg"},
        };
    }
}
