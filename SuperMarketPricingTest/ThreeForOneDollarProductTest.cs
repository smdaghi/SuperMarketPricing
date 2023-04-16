using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class ThreeForOneDollarProductTest
	{
        [TestMethod]
        public void ThreeForOneDollarProductUnitTest()
        {
            IProductPricing productPricing = new ThreeForOneDollarProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "Soap",
                Price = 0.5M
            };
            OrderLine order = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 5
            };
            //Act
            decimal price = order.GetPrice();
            //Assert
            Assert.AreEqual(2, price);
        }

        [TestMethod]
        public void ThreeForOneProductTest()
        {
            IProductPricing productPricing = new ThreeForOneDollarProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "Soap",
                Price = 0.5M
            };
            OrderLine order = new OrderLine(productPricing)
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
            cart.OrderLines.Add(order);
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(2, price);
        }

        [TestMethod]
        public void ThreeForOneDollarMultipleProduct()
        {
            IProductPricing productPricing = new ThreeForOneDollarProductPricing();
            Product product1 = new Product
            {
                Id = 1,
                Name = "Soap",
                Price = 0.5M
            };
            Product product2 = new Product
            {
                Id = 1,
                Name = "Bread",
                Price = 0.75M
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
                Quantity = 4
            };
            Cart cart = new Cart
            {
                OrderLines = new[] { orderLine1, orderLine2}
            };
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(3.75M, price);
        }
    }
}

