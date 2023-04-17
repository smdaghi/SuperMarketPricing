using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class TwoPoundsOneDollarPricingTest
	{
        [TestMethod]
        public void TwoPoundsOneDollarPricingUnitTest()
		{
            IProductPricing productPricing = new TwoPoundsOneDollarPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "Candy",
                Weight = 20,
                Unit = UnitEnum.Ounces
            };
            OrderLine order = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product
            };
            //Act
            decimal price = order.GetPrice();
            //Assert
            Assert.AreEqual(0.625M, price);
        }

        [TestMethod]
        public void TwoPoundsOneDollarPricingCardTest()
        {
            IProductPricing productPricing = new TwoPoundsOneDollarPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "Candy",
                Weight = 20,
                Unit = UnitEnum.Ounces
            };
            OrderLine order = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product
            };
            Cart cart = new Cart
            {
                OrderLines = new List<OrderLine>()
            };
            //
            cart.OrderLines.Add(order);
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(0.625M, price);
        }
    }
}

