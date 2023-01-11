using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Marital:IEntity
    {
        public int MaritalId { get; set; }
        public string MaritalName { get; set; }
    }
}
