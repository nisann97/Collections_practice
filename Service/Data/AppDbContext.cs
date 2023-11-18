using System;
using Domain.Models;
namespace Service.Data
{
	public static class AppDbContext
	{
		public static List<Author> Authors()
		{
			return new List<Author>()
			{
				new Author { Id = 1, Name = "Nisa", Surname = "Narimanova", Age = 26 },
				new Author { Id = 2, Name = "Arzu", Surname = "Kerimli", Age = 25 },
				new Author { Id = 3, Name = "Maryam", Surname = "Aliyeva", Age = 23 },
				new Author { Id = 4, Name = "Matanat", Surname = "Abbasova", Age = 21 }

			};

		}

		public static List<Employee> Employees()
		{
			return new List<Employee>()
			{
				new Employee{Id = 1, Name = "Nisa", Surname = "Narimanova", Salary = 2200, Birthday = new DateTime(1997,12,31) },
				new Employee{Id=2, Name = "Arzu", Surname = "Kerimli", Salary = 1800, Birthday = new DateTime(1998,05,12) },
				new Employee {Id =3, Name="Maryam", Surname = "Aliyeva", Salary = 1500, Birthday = new DateTime(2000, 07,14)}

			};
		}

		public static List<User> Users()
		{
			return new List<User>
			{
				new User { Id = 1, Email = "nnarimanova@gmail.com", Password = "123"},
				new User { Id = 2, Email = "rmammadli@gmail.com", Password = "123"},
				new User { Id = 3, Email = "amahammadli@gmail.com", Password = "123"}
			};
		}

		public static List<Product> Products()
		{
			return new List<Product>
			{
				new Product { Id = 1, Name = "Iphone", Price = 2000, Count = 5},
				new Product { Id = 2, Name = "Samsung", Price = 1500, Count = 4},
				new Product{ Id = 3, Name = "Nokia", Price = 500, Count = 2}
			};
		}
    }
}

