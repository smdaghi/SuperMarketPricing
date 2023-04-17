using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class PricingPerPound : IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return UnitConversion.WeightInPound(order.Product.Weight, order.Product.Unit) * order.Product.Price;
        }
    }
}

