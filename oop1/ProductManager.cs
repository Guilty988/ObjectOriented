using System;
namespace oop1
{
	public class ProductManager
	{
		public void Add(Product product) {

			Console.WriteLine("---- Products ----");
			Console.WriteLine("Product Id : " + product.ProductId);
            Console.WriteLine("Category Id : " + product.CategoryId);
            Console.WriteLine("Name : " + product.ProductName);
            Console.WriteLine("Price : " + product.UnitPrice);
            Console.WriteLine("Stock : " + product.UnitsInStock);
			Console.WriteLine("------------------");

        }

		public void Update(Product product) {

			Console.WriteLine("Updated!");
		}

		public int Plus(int number1,int number2) {

			return number1 + number2;
		}
        public void Plus2(int number1, int number2)
        {
			var result = number1 + number2;
			Console.WriteLine(result);
        }

    }
}

