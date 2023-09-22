using System;
namespace oop1
{
	//Snippet 
	public class Product
	{
		//Primary Key
		public int ProductId { get; set; }
		//Foreing Key
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
		public double UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
	}
}

