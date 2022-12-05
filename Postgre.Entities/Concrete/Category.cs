using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    [Table("category")]
    public class Category : IEntity
    {
        [Key]
        [Column("categoryId")]
        public int CategoryId { get; set; }
        [Column("categoryName")]
        public string CategoryName { get; set; }



        public virtual List<Person> people { get; set; }
    }
}
