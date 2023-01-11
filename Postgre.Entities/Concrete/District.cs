using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class District :IEntity
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set;}
    }
}
