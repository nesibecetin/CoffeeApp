using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        string Add(Customer customer);

        List<Customer> getAll();
    }
}
