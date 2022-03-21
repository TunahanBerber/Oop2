using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndiviualCustomer customer1 = new IndiviualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Id = 1;
            customer1.Name = "Melek";
            customer1.Surname = "Demirkaya";
            customer1.NationalIdentity = "12345678912";
            
            //Tüzel Müşteri Kodlamaio

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CompanyName = "KodlamaİO";
            customer2.CustomerNumber = "98765";
            customer2.Id = 2;
            customer2.TaxNumber= "123456789";

            //soLid
            
            // Müşteri classı hem gerçek hem tüzel müşterinin referansını tutabilir
            Customer customer3 = new IndiviualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
