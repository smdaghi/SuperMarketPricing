﻿using System;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
	public class TwoPoundsOneDollarPricing: IProductPricing
    {
        public decimal GetPrice(OrderLine order)
        {
            return 0;
        }
    }
}
