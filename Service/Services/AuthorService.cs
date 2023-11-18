using System;
using Service.Services.Interfaces;
using Domain.Models;
using Service.Data;
namespace Service.Services
{
	public class AuthorService : IAuhorService
	{

		public List<Author> GetAuthorsByAge(int age)
		{
			return AppDbContext.Authors().Where(m => m.Age >= age).ToList();
		}
	}
}
 