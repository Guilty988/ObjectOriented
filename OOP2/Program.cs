using System;
using OOP2;

namespace OOP2;
class Program
{
    static void Main(string[] args)
    {
        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.CustomerId = 1;
        customer1.CustomerNo = "12345";
        customer1.Name = "Doğukan";
        customer1.LastName = "zorer";
        customer1.TcNo = "123456";


        //Kodlama.io
        CorporateCustomer customer2 = new CorporateCustomer();
        customer2.CustomerId = 2;
        customer2.CustomerNo = "2131231";
        customer2.TaxNumber = "1231231";
        customer2.CompanyName = "Farewell";

        //SOLİD
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer1);
        customerManager.Add(customer2);
        


    }
}