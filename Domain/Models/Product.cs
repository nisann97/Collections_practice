using System;
namespace Domain.Models
{
	public class Product : BaseEntity
	{
		public double Price { get; set; }
		public int Count { get; set; }
		public string Name { get; set; }
	}
}

