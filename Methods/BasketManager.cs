using System;
namespace Methods
{
	public class BasketManager
	{

		//Naming convention
		//syntax
		public void Add(Product product)
		{

			Console.WriteLine("Product has been added :" + product.Name);
		}

        //This type of function writing is wrong
        //because the values coming from the parameter do not belong to the properties in the product class.
        public void AddAlternative(string productName,string description,double price,int stock)
		{
			Console.WriteLine("Product has been added :" + productName);
		}


    }
}

