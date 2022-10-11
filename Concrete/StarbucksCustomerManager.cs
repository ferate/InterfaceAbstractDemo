using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {           
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                //throw new Exception("Gerçek Bir Kişi Değil ");
                Console.WriteLine("Gerçek Bir Kişi Değil ");
            }


            // Bu kısım base classtan geliyor ve ortak işlemlerin yapılmasını sağlıyor.
            // Biz yukarıda bu classa has kontrolleri yaparak özelleştirebiliriz
            //Save(customer);


        }

      
    }
}
