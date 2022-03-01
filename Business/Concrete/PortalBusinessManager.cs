using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PortalBusinessManager:BaseCustomerManager
    {
        public PortalBusinessManager(ICustomerDal customerDal) : base(customerDal)
        {


        }
    }
}
