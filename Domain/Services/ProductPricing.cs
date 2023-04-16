using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
	public class ProductPricing: IProductPricing
    {
		public ProductPricing()
		{

		}

        public decimal GetPrice(OrderLine order)
        {
            return order.Product.Price * order.Quantity;
        }
    }
}

