using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2Array.Model
{
    class Product
    {
        private string name;
        private int price;
        private int quality;
        private int categoryId;

        public Product()
        {

        }

        public Product(string name, int price, int quality, int categoryId)
        {
            this.name = name;
            this.price = price;
            this.quality = quality;
            this.categoryId = categoryId;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quality { get => quality; set => quality = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
    }
}
