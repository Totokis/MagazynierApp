using System.Collections.Generic;

namespace MagazynierApp.Shared
{
    public class Machine
    {
        public const int MaxCapacity = 1080;
        public const int MinCapacity = 100;
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Localization { get; set; }
        
        public int Capacity { get; set; }

        public string ImageUrl { get; set; }
        
        public string Description { get; set; }

        public List<Product> ProductsList = new List<Product>();


        public int CurrentNumberOfProducts
        {
            get
            {
                int amount = 0;
                foreach (var product in ProductsList)
                {
                    amount += product.Quantity;
                }
                return amount;
            }
        }
    }

}
