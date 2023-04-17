using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
	public class TwoPoundsOneDollarPricing: IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return (UnitConversion.WeightInPound(order.Product.Weight, order.Product.Unit) / 2M) * 1.0M;
        }
    }
}

