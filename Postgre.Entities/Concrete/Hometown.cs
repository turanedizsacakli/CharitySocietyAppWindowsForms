using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities
{
    public class Hometown: IEntity
    {
        public int HometownId { get; set; }
        public string HometownName { get; set; }
    }
}
