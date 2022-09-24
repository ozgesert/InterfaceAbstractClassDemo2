using InterfaceAbstractClassDemo2.Absract;
using InterfaceAbstractClassDemo2.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;



namespace InterfaceAbstractClassDemo2.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealCustomerManager(Customer customer)
        {
            return true;
            
        }
    }
}
