using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class DiscountProductPricing : IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return 0;
        }
    }
}

