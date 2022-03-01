using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public class CustomerRepositoryDal : ICustomerDal
    {
        List<Customer> _customer;
        public CustomerRepositoryDal()
        {
            _customer = new List<Customer>() { new Customer { Id = 1, BirthOfDate = new DateTime(1998, 1, 22), FirstName = "Nesibe", LastName = "Çetin", NationaltyId = "12345679891" } };

        }
        public Customer Add(Customer entity)
        {
            _customer.Add(entity);
            return entity;
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return _customer;
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
