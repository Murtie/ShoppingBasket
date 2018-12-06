using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    public class PromoOfferBuyThreeMilkGetOneFree : IPromoOffer
    {
        public decimal CalculateOfferDiscount(List<IBasketItem> basketItems)
        {
            decimal totalDiscount = 0m;

            decimal discountAmount = 0m;
            discountAmount = basketItems.Where(m => m.ProductName.Equals("Milk")).Select(m => m.Price).First() * 1;

            int numTimesToApply = basketItems.Where(m => m.ProductName.Equals("Milk")).Select(m => m.Quantity).Sum() / 4;

            totalDiscount = discountAmount * numTimesToApply;


            return totalDiscount;
        }

        public bool IsApplicable(List<IBasketItem> basketItems)
        {
            if (basketItems.Exists(m => m.ProductName.Equals("Milk")) &&
                basketItems.Where(m => m.ProductName.Equals("Milk")).Select(m => m.Quantity).Sum() >= 4)
            {
                return true;
            }

            return false;
        }
    }
}
