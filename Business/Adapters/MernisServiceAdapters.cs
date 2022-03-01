using Business.Abstract;
using Entities;
using ServiceReference3;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;

namespace Business.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        [ComVisible(true)] //COM nesnesi olarak görülebilmesini sağlar

        public bool CheckIfRealPerson(Customer customer)
        {
            BasicHttpsBinding binding = new BasicHttpsBinding();
            EndpointAddress address = new EndpointAddress("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
            KPSPublicSoapClient client = new KPSPublicSoapClient(binding, address);

            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationaltyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthOfDate.Year);

        }
    }
}
