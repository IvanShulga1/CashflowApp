﻿using System;
namespace Cashflow.Models
{
	public class User
	{
		public User()
		{
		}

		public int Id { get; set; }
		public string FullName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

		List<Category> categories;
	}
}

