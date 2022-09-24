using InterfaceAbstractClassDemo2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractClassDemo2.Absract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealCustomerManager(Customer customer);
    }
}
