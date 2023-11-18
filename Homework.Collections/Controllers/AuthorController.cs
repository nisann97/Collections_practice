using System;
using Service.Services.Interfaces;
using Service.Services;
using Service.Services;
namespace Homework.Collections.Controllers
{
	public class AuthorController
	{
		private readonly IAuhorService _authorService;

		public AuthorController()
		{
			_authorService = new AuthorService();
		}

		public void GetByAge()
		{
			int age = 25;

			var res = _authorService.GetAuthorsByAge(age);

			foreach(var item in res)
			{
				Console.WriteLine(item.Name + " " + item.Surname);
			}
            

        }
    }
}

