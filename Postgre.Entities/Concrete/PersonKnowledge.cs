using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    public class PersonKnowledge :IEntity
    {
        [Key]
        [Column("knowledgeId")]
        public int KnowledgeId { get; set; }
        [Column("knowledge")]
        public string Knowledge { get; set; }

        public virtual List<Person> people { get; set; }

    }
}
