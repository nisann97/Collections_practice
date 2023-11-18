using System;
using Service.Data;
using Domain.Models;
using Service.Services.Interfaces;
namespace Service.Services
{
	public class ProductService : IProductService
	{
		public List<Product> GetAll()
		{
			return AppDbContext.Products();
		}

		public List<Product> Search(string searchText)
		{
			return AppDbContext.Products().Where(m => m.Name.Contains(searchText)).ToList();
		}
	}
}

