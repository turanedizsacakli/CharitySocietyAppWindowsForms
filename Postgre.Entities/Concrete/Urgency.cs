using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Urgency :IEntity
    {
        public int UrgencyId { get; set; }
        public string UrgencyName { get; set; }


        public virtual List<Person> people { get; set; }
    }
}
