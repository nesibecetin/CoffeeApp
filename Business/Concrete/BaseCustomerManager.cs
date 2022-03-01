using Business.Abstract;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public BaseCustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public virtual string Add(Customer customer)
        {
            
            return "kaydedildi.";

        }

        public List<Customer> getAll()
        {

            return _customerDal.GetAll();

        }
    }
}
