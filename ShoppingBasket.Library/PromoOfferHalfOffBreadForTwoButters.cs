using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    public class PromoOfferHalfOffBreadForTwoButters : IPromoOffer
    {
        public decimal CalculateOfferDiscount(List<IBasketItem> basketItems)
        {
            decimal discountAmount = 0m;
            discountAmount = basketItems.Where(m => m.ProductName.Equals("Bread")).Select(m => m.Price).First() * 0.5m;

            int numTimesToApply = basketItems.Where(m => m.ProductName.Equals("Butter")).Select(m => m.Quantity).Sum() / 2;

            decimal maxDiscount = 0m;

            maxDiscount = discountAmount * numTimesToApply;

            int numberOfItemsForDiscount = basketItems.Where(m => m.ProductName.Equals("Bread")).Select(m => m.Quantity).Sum();

            decimal totalDiscountOnQuantity = 0m;
            totalDiscountOnQuantity = discountAmount * numberOfItemsForDiscount;

            decimal totalDiscount = 0m;

            totalDiscount = maxDiscount <= totalDiscountOnQuantity ? maxDiscount : totalDiscountOnQuantity;

            return totalDiscount;
        }

        public bool IsApplicable(List<IBasketItem> basketItems)
        {
            if (basketItems.Exists(m => m.ProductName.Equals("Bread")) && basketItems.Exists(m => m.ProductName.Equals("Butter")))
            {
                if (basketItems.Exists(m => m.ProductName.Equals("Butter")) &&
                    basketItems.Where(m => m.ProductName.Equals("Butter")).Select(m => m.Quantity).Sum() >= 2)
                    return true;
            }

            return false;
        }
    }
}
