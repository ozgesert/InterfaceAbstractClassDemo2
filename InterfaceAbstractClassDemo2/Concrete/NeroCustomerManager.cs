using InterfaceAbstractClassDemo2.Absract;
using InterfaceAbstractClassDemo2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractClassDemo2.Concrete
{
    public class NeroCustomerManager :BaseCustomerManager //,ICustomerCheckServis deyip implemente de edebiliriz
    {
        ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {

            if (_customerCheckService.CheckIfRealCustomerManager(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }

    }
}
