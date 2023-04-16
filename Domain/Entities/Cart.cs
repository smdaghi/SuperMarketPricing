using System;
namespace Domain.Entities
{
	public class Cart
	{
        public IList<OrderLine> OrderLines { get; set; }
        public Cart()
        {
            OrderLines = new List<OrderLine>();
        }
        public decimal GetTotalPrice()
        {
            return 0;
        }
    }
}

