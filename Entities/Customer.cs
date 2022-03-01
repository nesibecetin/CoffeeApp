using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string NationaltyId { get; set; }
    }
}
