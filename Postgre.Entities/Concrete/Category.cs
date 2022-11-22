using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    [Table("category")]
    public class Category: IEntity
    {
        [Column("categoryId")]
        public int categoryId { get; set; }

        [Column("categoryname")]
        public string categoryName { get; set; }

        public virtual List<Person> people{ get; set; }
    }
}
