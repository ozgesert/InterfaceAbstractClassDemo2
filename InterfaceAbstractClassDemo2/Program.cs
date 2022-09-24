using InterfaceAbstractClassDemo2.Absract;
using InterfaceAbstractClassDemo2.Concrete;
using InterfaceAbstractClassDemo2.Entity;
using System;

namespace InterfaceAbstractClassDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            //baseCustomerManager.Save(new Entity.Customer {DateYear= new DateTime(1996,3,14),
            //    FirstName = "Özge" , LastName="Sert" , NationalityId="71698093216"});

            BaseCustomerManager baseCustomerManager1 = new NeroCustomerManager(new MernisServiceAdapter());
            baseCustomerManager1.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 3, 14),
                FirstName = "Özge",
                LastName = "Sert",
                NationalityId = "71698093216"

            }) ;

        }


    }
}
