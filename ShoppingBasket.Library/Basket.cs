using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{

    public class Basket : IBasket
    {
        private readonly List<IBasketItem> _basketitems;

        public Basket()
        {
            _basketitems = new List<IBasketItem>();
        }

        public List<IBasketItem> BasketItems
        {
            get { return _basketitems; }
        }


        public void AddItem(IBasketItem basketItem)
        {
            _basketitems.Add(basketItem);
        }

        public decimal Total()
        {
            decimal total = 0m;
            total = _basketitems.Sum(m => m.Price * m.Quantity);
            return total;
        }

    }
}