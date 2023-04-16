using System;
using Domain.Entities;

namespace Business.Services
{
	public class CartPricing
	{
        public decimal TotalCartPrice(Cart cart)
        {
            return cart.GetTotalPrice();
        }
    }
}

