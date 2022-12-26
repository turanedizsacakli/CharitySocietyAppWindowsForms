using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class Urgency :IEntity
    {
        [Key]
        [Column("urgencyId")]
        public int UrgencyId { get; set; }
        [Column("urgencyName")]
        public string UrgencyName { get; set; }


        public virtual List<Person> people { get; set; }
    }
}
