using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        Customer Get(Expression<Func<Customer, bool>> filter);
        Customer Add(Customer entity);
        void Delete(Customer entity);
        void Update(Customer entity);
    }
}
