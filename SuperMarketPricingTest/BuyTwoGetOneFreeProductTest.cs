using System;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;

namespace SuperMarketPricingTest
{
    [TestClass]
    public class BuyTwoGetOneFreeProductTest
	{
        [TestMethod]
        public void BuyTwoGetOneFreeSimpleProduct()
		{
            

            IProductPricing productPricing = new BuyTwoGetOneFreeProductPricing();
            Product product = new Product
            {
                Id = 1,
                Name = "water bottle",
                Price = 6
            };
            OrderLine buyTwoGetOneFreeOrder = new OrderLine(productPricing)
            {
                Id = 1,
                Product = product,
                Quantity = 3
            };
            Cart cart = new Cart
            {
                OrderLines = new List<OrderLine>()
            };
            //
            cart.OrderLines.Add(buyTwoGetOneFreeOrder);
            //Act
            decimal price = cart.GetTotalPrice();
            //Assert
            Assert.AreEqual(12, price);
        }

        [TestMethod]
        public void BuyTwoGetOneFreeMultipleProduct()
        {
            IProductPricing productPricing = new BuyTwoGetOneFreeProductPricing();
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
                Quantity = 6
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
                Quantity = 3
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
            Assert.AreEqual(42.6M, price);
        }
    }
}