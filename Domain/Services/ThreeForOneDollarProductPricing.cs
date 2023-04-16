using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ThreeForOneDollarProductPricing : IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return (order.Quantity / 3) + (order.Quantity % 3) * order.Product.Price;
        }
    }
}

