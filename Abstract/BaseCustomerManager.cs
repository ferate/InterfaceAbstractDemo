using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    
    public abstract class BaseCustomerManager : ICustomerCheckManager
    {

        // virtual terimi inherit edilen classlar tarafından bu metodun ezilebileceğine izin verilmesini sağlıyor
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veritabanına Yazma İşlemi Tamamlandı "+ customer.FirstName);
        }
    }
}
