using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IAuhorService
	{
       List<Author> GetAuthorsByAge(int age);
    }
}

