using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{

    public class BasketItem : IBasketItem
    {
        public decimal Price
        {
            get; set;
        }

        public string ProductName
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }
    }
}
