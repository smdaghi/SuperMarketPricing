using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class DiscountProductPricingTest
	{
        [TestMethod]
        public void DiscountSimpleProductUnitTest()
        {
            IProductPricing productPricing = new DiscountProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "TV",
                Price = 1200,
                Discount = 0.5m
            };
            OrderLine order = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 1
            };
            //Act
            decimal price = order.GetPrice();
            //Assert
            Assert.AreEqual(600, price);
        }
        [TestMethod]
        public void DiscountSimpleProduct()
        {


            IProductPricing productPricing = new DiscountProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "TV",
                Price = 1200,
                Discount = 0.5m
            };
            OrderLine order = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 1
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
            Assert.AreEqual(600, price);
        }
        [TestMethod]
        public void DiscountMultipleProduct()
        {
            IProductPricing productPricing = new DiscountProductPricing();
            Product product1 = new Product
            {
                Id = 1,
                Name = "TV",
                Price = 1200,
                Discount = 0.5m
            };
            Product product2 = new Product
            {
                Id = 1,
                Name = "Table",
                Price = 100,
                Discount = 0.2m
            };
            Product product3 = new Product
            {
                Id = 1,
                Name = "Pasta",
                Price = 3,
                Discount = 0.1m
            };
            Product product4 = new Product
            {
                Id = 1,
                Name = "Bottle of soda",
                Price = 4,
                Discount = 0.5m
            };
            OrderLine orderLine1 = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product1,
                Quantity = 1
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
                Quantity = 5
            };
            Cart cart = new Cart
            {
                OrderLines = new[] { orderLine1, orderLine2, orderLine3, orderLine4 }
            };
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(855.4M, price);
        }
    }
}

