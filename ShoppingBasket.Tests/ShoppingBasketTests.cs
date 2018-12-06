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
        /// Given the basket has 2 butter and 2 bread when I total 
        /// the basket then the total should be £3.10
        /// </summary>
        [Test]
        public void BasketTotal_GivenTwoButterBread_ReturnsTotal310p()
        {
            //Given
            var basket = new Basket();
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
        /// Using a more dynamic Test method by supplied parameters
        /// Noticed that it takes a lot longer to complete than the previous static test method
        /// </summary>
        [TestCase(1, 1, 1, 2.95)]
        public void BasketTotal_GivenButterMilkBreadQuantity_ReturnsCorrectTotal(
          int BreadQty, int ButterQty, int MilkQty, decimal CorrectTotal)
        {
            //Given
            var basket = new Basket();
            var Bread = new BasketItem() { ProductName = "Bread", Quantity = BreadQty, Price = 1.00m };
            var Butter = new BasketItem() { ProductName = "Butter", Quantity = ButterQty, Price = 0.80m };
            var Milk = new BasketItem() { ProductName = "Milk", Quantity = MilkQty, Price = 1.15m };

            basket.AddItem(Bread);
            basket.AddItem(Butter);
            basket.AddItem(Milk);

            //When
            var result = basket.Total();

            //Then
            Assert.That(result, Is.EqualTo(CorrectTotal));
        }

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
