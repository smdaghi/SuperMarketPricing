using System;
using Domain.Entities;

namespace Domain.Interfaces
{
	public interface IProductPricing
	{
        public decimal GetPrice(OrderLine order);
    }
}

