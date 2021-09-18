using InterfaceAbstractsDemo.Abstract;
using InterfaceAbstractsDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractsDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {


            return true;
        }
    }
}
