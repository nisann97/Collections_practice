using System;
using Service.Services.Interfaces;
using Service.Services;
namespace Homework.Collections.Controllers
{
	public class AccountController
	{
		private readonly IAccountService _accountService;


		public AccountController()
		{
			_accountService = new AccountService();
		}

		public bool Login()
		{
			Console.WriteLine("Please enter your email:");
			Email:  string email = Console.ReadLine();

			Console.WriteLine("Please add your password:");
			string password = Console.ReadLine();

			bool result = _accountService.Login(email, password);

			if (!result)
			{
				Console.WriteLine("Email or password is wrong, please enter inputs again!");
				goto Email;
			}

			return true; 

		}

	}
}

