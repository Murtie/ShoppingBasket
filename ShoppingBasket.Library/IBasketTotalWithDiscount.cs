using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    /// <summary>
    /// New interface to add discount functionality to shopping baskets.
    /// </summary>
    interface IBasketTotalwithDiscount
    {
        decimal TotalwithDiscount();
    }
}
