using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class PricingPerPoundTest
	{
        [TestMethod]
        public void PricingPerPoundUnitTest()
		{
            IProductPricing productPricing = new PricingPerPound();
            Product product = new Product
            {
                Id = 1,
                Name = "Potatoes",
                Price = 1.99M,
                Weight = 4,
                Unit = UnitEnum.Ounces
            };
            OrderLine orderLine = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product
            };
            //Act
            decimal price = orderLine.GetPrice();
            //Assert
            Assert.AreEqual(0.4975M, price);
        }


        [TestMethod]
        public void PricingPerPoundCartTest()
        {
            IProductPricing productPricing = new PricingPerPound();
            Product product = new Product
            {
                Id = 1,
                Name = "Potatoes",
                Price = 1.99M,
                Weight = 4,
                Unit = UnitEnum.Ounces
            };
            OrderLine orderLine = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product
            };
            Cart cart = new Cart
            {
                OrderLines = new List<OrderLine>()
            };
            //
            cart.OrderLines.Add(orderLine);
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(0.4975M, price);
        }
    }
}

