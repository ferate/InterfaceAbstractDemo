using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReference.KPSPublicSoapClient;
//using static Mernis.KPSPublicSoapClient;


namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient mernisClient = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year).GetAwaiter().GetResult();

            bool dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            return dogrulamaSonucu;
        }
    }
}
