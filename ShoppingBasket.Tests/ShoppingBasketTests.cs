using NUnit.Framework;
using ShoppingBasket.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Tests
{
    /// <summary>
    /// Using the BDD framework's  GWT style
    /// Referenced Martin Fowler's blog on GivenWhenThen https://martinfowler.com/bliki/GivenWhenThen.html
    /// </summary>
    public class ShoppingBasketTests
    {
        /// <summary>
        /// Scenario 3 - Given the basket has 4 milk when I total the basket then the 
        /// total should be £3.45
        /// </summary>
        [Test]
        public void BasketTotal_GivenFourMilk_ReturnsTotal345p()
        {
            //Given
            List<IPromoOffer> promoOffers = new List<IPromoOffer>();
            promoOffers.Add(new PromoOfferBuyThreeMilkGetOneFree());
            var promoCalculator = new PromoOfferDiscountCalculator(promoOffers);
            var basket = new Basket(promoCalculator);
            var Milk = new BasketItem() { ProductName = "Milk", Quantity = 4, Price = 1.15m };

            basket.AddItem(Milk);

            //When
            var result = basket.TotalwithDiscount();

            //Then
            Assert.That(result, Is.EqualTo(3.45m));
        }


        /// <summary>
        /// Scenario 2 - Given the basket has 2 butter and 2 bread when I total 
        /// the basket then the total should be £3.10
        /// </summary>
        [Test]
        public void BasketTotal_GivenTwoButterBread_ReturnsTotal310p()
        {
            //Given
            List<IPromoOffer> promoOffers = new List<IPromoOffer>();
            promoOffers.Add(new PromoOfferHalfOffBreadForTwoButters());
            var promoCalculator = new PromoOfferDiscountCalculator(promoOffers);
            var basket = new Basket(promoCalculator);
            var Bread = new BasketItem() { ProductName = "Bread", Quantity = 2, Price = 1.00m };
            var Butter = new BasketItem() { ProductName = "Butter", Quantity = 2, Price = 0.80m };

            basket.AddItem(Bread);
            basket.AddItem(Butter);

            //When
            var result = basket.TotalwithDiscount();

            //Then
            Assert.That(result, Is.EqualTo(3.10m));
        }


     
        /// <summary>
        /// Scenario 1 - Given the basket has 1 bread, 1 butter and 1 milk when 
        /// I total the basket then the total should be £2.95
        /// </summary>
        [Test]
        public void BasketTotal_GivenOneButterMilkBread_ReturnsTotal295p()
        {
            //Given
            var basket = new Basket();
            var Bread = new BasketItem() { ProductName = "Bread", Quantity = 1, Price = 1.00m };
            var Butter = new BasketItem() { ProductName = "Butter", Quantity = 1, Price = 0.80m };
            var Milk = new BasketItem() { ProductName = "Milk", Quantity = 1, Price = 1.15m };

            basket.AddItem(Bread);
            basket.AddItem(Butter);
            basket.AddItem(Milk);

            //When
            var result = basket.Total();

            //Then
            Assert.That(result, Is.EqualTo(2.95m));
        }
    }
}
