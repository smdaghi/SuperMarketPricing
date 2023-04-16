using System;
using Domain.Entities;

namespace Business.Interfaces
{
	public interface ICartPricing
	{
        public decimal TotalCartPrice(Cart cart);
    }
}