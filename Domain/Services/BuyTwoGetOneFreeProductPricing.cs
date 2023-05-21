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
            // Calculer le nombre de paires de produits
            int nombrePaires = order.Quantity / 2;

            // Calculer le prix total en prenant en compte la promotion
            return nombrePaires * order.Product.Price;
        }
    }
}

