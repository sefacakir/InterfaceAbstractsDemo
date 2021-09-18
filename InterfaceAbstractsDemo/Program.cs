using InterfaceAbstractsDemo.Abstract;
using InterfaceAbstractsDemo.Concrete;
using System;

namespace InterfaceAbstractsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseCustomerManager customerManager = new SturbuckCustomerManager();
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(2001, 1, 1),FirstName = "Sefa", LastName = "Çakır",NationalityId = "10101010100" });
            Console.WriteLine();

        }
    }
}
