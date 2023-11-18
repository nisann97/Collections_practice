using System;
using Domain.Models;
namespace Service.Services.Interfaces
{
	public interface IEmployeeService
	{

		List<Employee> GetEmployeesByBirthday(DateTime startDate, DateTime endDate, double salary);

		int GetEmployeeCount(DateTime startDate, DateTime endDate, double salary);
	}
}

