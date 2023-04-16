using System;
namespace Domain.Entities
{
	public class Product
	{
        public long Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Weight { get; set; }
        public UnitEnum Unit { get; set; }
    }
}

