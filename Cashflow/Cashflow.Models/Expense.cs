using System;
namespace Cashflow.Models
{
	public class Expense
	{
		public int Id { get; set; }
		public DateTime TransactionDate { get; set; }
		public string Description { get; set; }

		Category category;

		List<Product> products;
	}
}

