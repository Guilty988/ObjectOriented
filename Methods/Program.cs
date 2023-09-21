using System;

namespace Methods;

class Program
{
   static void Main(string[] args)
    {
        bool status = true;

        Product product1 = new Product();
        product1.Name = "Apple";
        product1.Price = 26;
        product1.Description = "Apple original";

        Product product2 = new Product();

        product2.Name = "Orange";
        product2.Price = 80;
        product2.Description = "From Florida";


        Product[] products = new Product[] {product1,product2};

        if(status != true) {

            Console.WriteLine("products cannot be accessed");

        }
        else {
            foreach (var product in products)
            {
                Console.WriteLine("Products:");
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("! --------------------- !");
            }
        }

        Console.WriteLine("------------- METHODS ----------------");
        //Instance
        //Encapsulation
        BasketManager basketManager = new BasketManager();
        basketManager.Add(product1);

    }

}