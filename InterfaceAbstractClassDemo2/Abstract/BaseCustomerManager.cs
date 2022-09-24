using InterfaceAbstractClassDemo2.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractClassDemo2.Absract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :" +customer.FirstName + customer.LastName);
        }
    }
}
