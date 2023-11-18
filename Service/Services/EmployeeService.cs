using System;
using Domain.Models;
using Service.Data;
using Service.Services.Interfaces;
namespace Service.Services
{
	public class EmployeeService : IEmployeeService
	{
		public List<Employee> GetEmployeesByBirthday(DateTime startDate, DateTime endDate, double salary)
		{
			return AppDbContext.Employees().Where(m => m.Birthday >= startDate && m.Birthday <= endDate && m.Salary > salary).ToList();
		}

		public int GetEmployeeCount(DateTime startDate, DateTime endDate, double salary)
		{
			return AppDbContext.Employees().Count(m => m.Birthday >= startDate && m.Birthday <= endDate && m.Salary > salary);
		}
	}
}

