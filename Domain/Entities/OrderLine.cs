using System;
using Domain.Interfaces;

namespace Domain.Entities
{
	public class OrderLine
	{
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        private readonly IProductPricing _productPricing;

        public OrderLine(IProductPricing productPricing)
        {
            _productPricing = productPricing;
            Product = new Product();
        }

        public decimal GetPrice()
        {
            return _productPricing.GetPrice(this);
        }
    }
}

