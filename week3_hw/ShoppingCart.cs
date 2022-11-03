using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw
{
    internal class ShoppingCart
    {
        private List<CartItem> _crtItemList;

        public ShoppingCart()
        {
            _crtItemList = new List<CartItem>();
        }

        //Add
        public void Add(CartItem crtItem)
        {
            _crtItemList.Add(crtItem);
        }
        //Remove
        public void Remove(int id)
        {
            var item = _crtItemList[id];
            _crtItemList.Remove(item);
        }
        //GetList
        public void GetList()
        {
            foreach (var item in _crtItemList)
            {
                Console.WriteLine($"{item.CaprtId} {item.Product.ProductName} {item.Quantity}");
            }
        }
        //GetBalance
        public int GetBalance()
        {
            int balance = 0;
            foreach (var item in _crtItemList)
            {
                balance += (item.Quantity * item.Product.Price);
            }
            return balance;
        }

    }
}
