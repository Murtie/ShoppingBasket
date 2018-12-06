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


        public decimal TotalwithDiscount()
        {
            decimal total = 0m;
            decimal discount = 0m;

            // Adding discount offer for Bread
            // Check if Bread and Butter are items in the basket
            if (_basketitems.Exists(m => m.ProductName.Equals("Bread")) &&
                _basketitems.Exists(m => m.ProductName.Equals("Butter")))
            {
                if (_basketitems.Exists(m => m.ProductName == "Butter" && m.Quantity >= 2))
                {
                    decimal discountAmount = 0m;
                    discountAmount = _basketitems.Where(m => m.ProductName.Equals("Bread")).Select(m => m.Price).First() * 0.5m;

                    int numTimesToApply = _basketitems.Where(m => m.ProductName == "Butter").Select(m => m.Quantity).Sum() / 2;

                    decimal maxDiscount = 0m;

                    maxDiscount = discountAmount * numTimesToApply;

                    int numberOfItemsForDiscount = _basketitems.Where(m => m.ProductName == "Bread").Select(m => m.Quantity).Sum();

                    decimal totalDiscountOnQuantity = 0m;
                    totalDiscountOnQuantity = discountAmount * numberOfItemsForDiscount;

                    discount = maxDiscount <= totalDiscountOnQuantity ? maxDiscount : totalDiscountOnQuantity;

                }

            }

            total = _basketitems.Sum(m => m.Price * m.Quantity) - discount;

            return total;
        }

    }
}