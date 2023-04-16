using System;
using System.Diagnostics;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class BuyTwoGetOneFreeProductPricing : IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return (order.Quantity / 3) * (2 * order.Product.Price)
                + (order.Quantity % 3) * order.Product.Price;
        }
    }
}

