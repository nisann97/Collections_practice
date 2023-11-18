using System;
namespace Service.Services.Interfaces
{
	public interface IAccountService
	{
		bool Login(string email, string password);
	}
}

