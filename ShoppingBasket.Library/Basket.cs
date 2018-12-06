using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Library
{

    public class Basket : IBasket, IBasketTotal, IBasketTotalwithDiscount
    {
        private readonly List<IBasketItem> _basketitems;
        private readonly IPromoOfferDiscountCalculator _promoOfferDiscountCalculator;


        public Basket()
        {
            _basketitems = new List<IBasketItem>();
        }

        public Basket(IPromoOfferDiscountCalculator promoOfferDiscountCalculator)
        {
            _promoOfferDiscountCalculator = promoOfferDiscountCalculator;
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


        public decimal TotalwithDiscount()
        {
            decimal total = 0m;
            decimal discount = 0m;

            discount = _promoOfferDiscountCalculator.CalculateDiscount(_basketitems);

            total = _basketitems.Sum(m => m.Price * m.Quantity) - discount;

            return total;
        }

    }
}