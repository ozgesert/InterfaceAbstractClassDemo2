using InterfaceAbstractClassDemo2.Absract;
using InterfaceAbstractClassDemo2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractClassDemo2.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
       private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        //public bool CheckIfRealCustomerManager(Customer customer)
        //{
        //    throw new NotImplementedException();
        //}

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
