using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class ProductPricingTest
	{
        [TestMethod]
        public void SimpleProductPricingUnitTest()
        {
            IProductPricing productPricing = new ProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "water bottle",
                Price = 6
            };
            OrderLine orderLine = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 5
            };
            //Act
            decimal price = orderLine.GetPrice();
            //Assert
            Assert.AreEqual(30, price);
        }
        [TestMethod]
        public void SimpleProductPricing()
		{
            IProductPricing productPricing = new ProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "water bottle",
                Price = 6
            };
            OrderLine orderLine = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 5
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
            Assert.AreEqual(30, price);
        }

        [TestMethod]
        public void MultipleSimpleProducPricing()
        {
            IProductPricing productPricing = new ProductPricing();
            Product product1 = new Product
            {
                Id = 1,
                Name = "water bottle",
                Price = 6
            };
            Product product2 = new Product
            {
                Id = 1,
                Name = "milk",
                Price = 3.2M
            };
            Product product3 = new Product
            {
                Id = 1,
                Name = "Butter",
                Price = 2.5M
            };
            Product product4 = new Product
            {
                Id = 1,
                Name = "Orange juice",
                Price = 7.2M
            };
            OrderLine orderLine1 = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product1,
                Quantity = 5
            };
            OrderLine orderLine2 = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product2,
                Quantity = 3
            };
            OrderLine orderLine3 = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product3,
                Quantity = 2
            };
            OrderLine orderLine4 = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product4,
                Quantity = 1
            };
            Cart cart = new Cart
            {
                OrderLines = new[] { orderLine1, orderLine2, orderLine3, orderLine4 }
            };
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(51.8M, price);
        }
    }
}

