using System;
using Domain.Models;
using Service.Services.Interfaces;
using Service.Services;
namespace Homework.Collections.Controllers
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}

		public void GetAllByBirthday()
		{
			double salary = 2000;
			DateTime startDate = new DateTime(1990, 01, 01);
			DateTime endDate = new DateTime(2000, 01, 01);

			var result = _employeeService.GetEmployeesByBirthday(startDate, endDate, salary);

			foreach(var item in result)
			{
				Console.WriteLine(item.Name + " " + item.Birthday);
			}
		}

		public void GetEmployeesCount()
		{
			double salary = 2000;
			DateTime startDate = new DateTime(1990, 01, 01);
			DateTime endDate = new DateTime(2000, 01, 01);

			Console.WriteLine(_employeeService.GetEmployeeCount(startDate, endDate, salary));
		}
	}
}

