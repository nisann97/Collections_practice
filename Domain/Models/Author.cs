using System;
namespace Domain.Models
{
	public class Author : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
	}
}

