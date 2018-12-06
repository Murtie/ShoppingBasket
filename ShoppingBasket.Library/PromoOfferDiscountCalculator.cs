using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{
    public class PromoOfferDiscountCalculator : IPromoOfferDiscountCalculator
    {
        private readonly List<IPromoOffer> _promoOffers;

        public PromoOfferDiscountCalculator(List<IPromoOffer> promoOffers)
        {
            _promoOffers = promoOffers;
        }

        public decimal CalculateDiscount(List<IBasketItem> basketItems)
        {
            decimal totalDiscount = 0m;
            _promoOffers.ForEach(m => {
                if (m.IsApplicable(basketItems))
                {
                    totalDiscount += m.CalculateOfferDiscount(basketItems);
                }
            });

            return totalDiscount;


        }
    }
}
