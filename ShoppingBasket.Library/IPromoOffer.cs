using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    public interface IPromoOffer
    {
        bool IsApplicable(List<IBasketItem> basketItems);
        decimal CalculateOfferDiscount(List<IBasketItem> basketItems);
    }
}
