using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw
{
    internal class Product
    {
        public int Price { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Product()
        {

        }
        public Product(int price, int productid, string productname)
        {
            this.Price = price;
            this.ProductId = productid;
            this.ProductName = productname; 
        }
    }
}
