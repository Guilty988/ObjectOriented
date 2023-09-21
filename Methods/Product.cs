using System;
namespace Methods
{
	public class Product
	{
        //Propertys
		public int ProductId { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
        public int  Stock { get; set; }

        // If you want to give a parameter value to the method, you should use a constructor.
        /* public Product(int productId,string name,double price,string description)
         {
             ProductId = productId;
             Name = name;
             Price = price;
             Description = description;
         }
        */
    }
}

