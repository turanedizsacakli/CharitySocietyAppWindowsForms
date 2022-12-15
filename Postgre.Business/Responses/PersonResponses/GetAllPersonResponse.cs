using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Business.Responses
{
    public class GetAllPersonResponse
    {
        public int PersonResponseId { get; set; }
        public string PersonResponseName { get; set; }
        public string PersonResponseSurname { get; set; }
        public string PersonResponseFatherName { get; set; }
        public string PersonResponseMotherName { get; set; }
        public string PersonResponseNationality { get; set; }
        public string PersonResponseBirthday { get; set; }
        public string PersonResponseBirthCountry { get; set; }
        public string PersonResponseLocalId { get; set; }

    }
}
