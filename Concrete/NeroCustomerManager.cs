using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        // Eğer biz TC No Doğrulama İşlemini Nero İçin de Yapmak İstersek 
        // TC No Doğrulama Servisini Sistemimize Aşağıdaki Şekilde Enjekte Ediyoruz
        // Ve Save kısmında override yaparak base classımızda yapılan Save işlemini ezip kendimiz özelleştiriyoruz

        //ICustomerCheckService _customerCheckService;
        //public NeroCustomerManager(ICustomerCheckService customerCheckService)
        //{
        //    _customerCheckService = customerCheckService;
        //}

        public override void Save(Customer customer)
        {

            base.Save(customer);
        }
    }
}
