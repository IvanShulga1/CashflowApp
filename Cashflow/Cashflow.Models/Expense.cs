using System;
namespace Cashflow.Models
{
	public class Expense
	{
		Category category;
		List<Product> products;

		public int Id { get; set; }
		public DateTime TransactionDate { get; set; }
		public string Description { get; set; }

	}
}

