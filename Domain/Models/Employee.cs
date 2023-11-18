using System;
namespace Domain.Models
{
	public class Employee : BaseEntity
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public double Salary { get; set; }
		public DateTime Birthday { get; set; }
	}
}

