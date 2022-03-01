using Business.Abstract;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public  class StarbucksBusinessManager :  BaseCustomerManager
    {

        ICustomerCheckService _customerCheckService;

        public StarbucksBusinessManager(ICustomerCheckService customerCheckService, ICustomerDal customerDal) : base(customerDal)
        {
            _customerCheckService = customerCheckService;
        }
        public override string Add(Customer customer)
        {
            var result = "";
            if (_customerCheckService.CheckIfRealPerson(customer) == true)
            {
               result = base.Add(customer).ToString();
          
            }
            else
                result ="geçersiz kişi";
            return result;

        }
    }
}
