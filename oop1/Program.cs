using System;
using oop1;

namespace Methods;

class Program
{

    static void Main(string[] args) {

        Product product1 = new Product();
        product1.ProductId = 1;
        product1.CategoryId = 1;
        product1.ProductName = "Table";
        product1.UnitPrice = 350;
        product1.UnitsInStock = 5;

        Product product2 = new Product { ProductId = 2, CategoryId = 5, ProductName = "Door" , UnitPrice = 350 , UnitsInStock = 14};
        
        //PascalCase   //CamelCase
        //Stack                              //Heep
        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        productManager.Add(product2);

        //plus2 method is void 
        productManager.Plus2(3, 6);

        //plus method return to int
        int result = productManager.Plus(3, 9);
        Console.WriteLine(result * 2);


    }


}