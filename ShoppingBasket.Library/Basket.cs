using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    ///
    /// Not following SOLID Design Principles
    /// Not open for extension but open for modification - OCP Fail
    /// Not following Dependency Inversion Principle - tightly coupled with BasketItem Class
    public class Basket
    {
        private readonly List<BasketItem> _basketitems;

        public Basket()
        {
            _basketitems = new List<BasketItem>();
        }

        public List<BasketItem> BasketItems
        {
            get { return _basketitems; }
        }


        public void AddItem(BasketItem basketItem)
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