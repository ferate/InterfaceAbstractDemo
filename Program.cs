using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface ve Abstract Class Çalışmasına Hoşgeldin ");


            //BaseCustomerManager customerManager = new NeroCustomerManager(); // İstenenler gereksinimler gereği TC No Doğrulamaya İhtiyacı Yok. 
            //BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager()); // Fake TC No Doğrulama İle Çalışabilirim
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());  // Mernis Doğrulamalı Çalışmak İçin Kullanılır
            customerManager.Save(new Customer() { Id = 1, DateOfBirth = new DateTime(1981, 10, 01), FirstName = "FERAT", LastName = "EFİL", NationalityId = "12561215" });
            Console.ReadLine();

        }
    }
}
