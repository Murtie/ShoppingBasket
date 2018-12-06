using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    public interface IPromoOfferDiscountCalculator
    {
        decimal CalculateDiscount(List<IBasketItem> basketItems);
    }
}
