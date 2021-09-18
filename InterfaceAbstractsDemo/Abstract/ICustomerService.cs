using InterfaceAbstractsDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractsDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
