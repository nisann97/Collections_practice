﻿using System;
namespace Domain.Models
{
	public class User : BaseEntity
	{
		public string Email { get; set; }
		public string Password { get; set; }
	}
}

