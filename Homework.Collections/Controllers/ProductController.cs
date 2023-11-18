using System;
using Service.Services.Interfaces;
using Service.Services;
namespace Homework.Collections.Controllers
{
	public class ProductController
	{
		private readonly IProductService _productService;

		public ProductController()
		{
			_productService = new ProductService();
		}

		public void GetAll()
		{
			var res = _productService.GetAll();


			foreach(var item in res)
			{
				Console.WriteLine(item.Name + " " + item.Price + " " + item.Count);
			}
		}

		public void Search()
		{
			Console.WriteLine("Enter the product:");
			string searchText = Console.ReadLine();

			var response = _productService.Search(searchText);

			foreach(var item in response)
			{
				string result = $"{item.Name} - {item.Count} - {item.Price}";
				Console.WriteLine(result);
			}
		}






	}
}

