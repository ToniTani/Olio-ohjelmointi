using System;
using System.Collections.Generic;
using System.Text;

namespace TaskInterface
{
    interface ICustomers
    {
        void AddCustomer(List<Customer> customer);
        void PrintCustomers();
    }
}
