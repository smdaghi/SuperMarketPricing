using System;
namespace Domain.Entities
{
	public class OrderLine
	{
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public OrderLine()
		{
            Product = new Product();
        }
        public decimal GetPrice()
        {
            return 0;
        }
    }
}

