using System;
using Domain.Models;
using Service.Services.Interfaces;
using Service.Data;
namespace Service.Services
{
	public class AccountService : IAccountService
	{
		public bool Login(string email, string password)
		{

			return AppDbContext.Users().Exists(m => m.Email == email && m.Password == password);			

		}
		
	}
}

