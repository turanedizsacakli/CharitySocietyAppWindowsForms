using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Control :IEntity
    {
        public int ControlId { get; set; }
        public string PersonId { get; set; }
        public string AddressId { get; set; }
        public string KnowledgeId { get; set; }
        
    }
}
