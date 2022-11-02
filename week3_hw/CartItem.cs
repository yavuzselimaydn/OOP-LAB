using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw
{
    internal class CartItem
    {
        public CartItem(int cartId, Product product, int quantity)
        {
            CartId = cartId;
            Product = product;
            Quantity = quantity;
        }

        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
