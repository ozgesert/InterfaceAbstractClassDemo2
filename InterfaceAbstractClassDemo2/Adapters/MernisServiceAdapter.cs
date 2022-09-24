using InterfaceAbstractClassDemo2.Absract;
using InterfaceAbstractClassDemo2.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReference.KPSPublicSoapClient;

namespace InterfaceAbstractClassDemo2
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomerManager(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
