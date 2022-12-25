using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Address :IEntity
    {
        public int AddressId { get; set; }
        public string AppealDate { get; set; }
        public string DetectDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Hometown { get; set; }
        public string PhoneNumberTwo { get; set; }
        public string PhoneNumberOne { get; set; }
        public string Street { get; set; }
        public string Build { get; set; }
        public string BuildNumber { get; set; }

        public virtual List<Person> people { get; set; }
    }
}
