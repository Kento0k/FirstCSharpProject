using System.Collections;
using System.Collections.Generic;

namespace FirstCSharpProject
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int SupplierId { get; set; }
        public Product(string name, decimal price, int supplierId)
        {
            Name = name;
            Price = price;
            SupplierId = supplierId;
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}", Name, Price);
        }
    }
}