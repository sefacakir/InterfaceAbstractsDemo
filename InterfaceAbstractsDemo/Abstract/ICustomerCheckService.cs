using InterfaceAbstractsDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractsDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
