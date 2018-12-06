using NUnit.Framework;
using ShoppingBasket.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket.Tests
{
    public class ShoppingBasketTests
    {

        /// <summary>
        /// Given the basket has 1 bread, 1 butter and 1 milk when 
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
