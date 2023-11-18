using System;
using Domain.Models;
namespace Service.Services.Interfaces
{
	public interface IProductService
	{

		List<Product> GetAll();
		List<Product> Search(string searchText);

	}
}

