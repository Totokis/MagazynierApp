using System;
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

        public int Capacity
        {
            get => _capacity;
            set
            {
                if(value<MinCapacity)
                    _capacity = MinCapacity;
                else if (value > MaxCapacity)
                    _capacity = MaxCapacity;
                else
                    _capacity = value;
            }
        }

        public string ImageUrl { get; set; }
        
        public string Description { get; set; }

        public List<Product> ProductsList
        {
            get => _productsList;
            set
            {
                if (CalculateAmount(value) > _capacity)
                {
                    value = new List<Product>();
                }
                else
                    _productsList = value;
            }
        }
        private int _capacity;
        private List<Product> _productsList = new List<Product>(MaxCapacity);


        public int CurrentNumberOfProducts
        {
            get
            {
                return CalculateAmount(ProductsList);
            }
        }
        private int CalculateAmount(List<Product> products)
        {

            int amount = 0;
            foreach (var product in products)
            {
                amount += product.Quantity;
            }
            return amount;
        }
    }

}
