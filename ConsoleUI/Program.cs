using Business.Adapters;
using Business.Concrete;
using DataAccess;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksBusinessManager(new MernisServiceAdapters(), new CustomerRepositoryDal());
            baseCustomerManager.Add(new Customer { BirthOfDate = new DateTime(1999, 10, 26), FirstName = "nesibe", LastName = "çetin", NationaltyId = "25697777777" });
            Console.WriteLine("-----Liste-------");
            foreach (var customer in baseCustomerManager.getAll())
            {
                Console.WriteLine("Adı:" + customer.FirstName);
            }
            Console.ReadLine();
        }
    }
}
