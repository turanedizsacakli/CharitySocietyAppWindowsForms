using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Control :IEntity
    {
        [Key]
        public int ControlId { get; set; }
        public int PersonId { get; set; }
        public int AddressId { get; set; }
        public int KnowledgeId { get; set; }
        
    }
}
