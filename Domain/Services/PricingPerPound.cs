using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class PricingPerPound : IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            switch (order.Product.Unit)
            {
                case UnitEnum.Pounds:
                    return order.Product.Weight * order.Product.Price;
                case UnitEnum.Ounces:
                    return (order.Product.Weight / 16.0M) * order.Product.Price;
                case UnitEnum.Grams:
                    return (order.Product.Weight / 453.592M) * order.Product.Price;
                default:
                    return 0;
            }
        }
    }
}

