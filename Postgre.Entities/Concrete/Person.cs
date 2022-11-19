using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.Entities.Concrete
{
    [Table ("person")]
    public class Person : IEntity
    {
        [Key]
        [Column("personId")]
        public int PersonId { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("fathername")]
        public string FatherName { get; set; }
        [Column("mothername")]
        public string MotherName { get; set; }
        [Column("nationality")]
        public string Nationality { get; set; }
        [Column("birthday")]
        public string Birthday { get; set; }
        [Column("birthcountry")]
        public string BirthCountry { get; set; }
        [Column("localid")]
        public string LocalId { get; set; }
    }
}
