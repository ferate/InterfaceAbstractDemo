using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckManager
    {
     
        void Save(Customer customer); // Save to Database Senaryo gereği
    }
}
