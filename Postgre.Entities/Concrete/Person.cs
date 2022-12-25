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
    [Table("person")]
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
        [Column("blood")]
        public string Blood { get; set; }
        [Column("work")]
        public string Work { get; set; }
        [Column("income")]
        public string Income { get; set; }
        [Column("outgoing")]
        public string Outgoing { get; set; }
        [Column("debt")]
        public string Debt { get; set; }
        [Column("aid")]
        public string Aid { get; set; }
        [Column("stuff")]
        public string Stuff { get; set; }
        [Column("student")]
        public string Student { get; set; }
        [Column("partnerLocalId")]
        public string PartnerLocalId { get; set; }
        [Column("childOneLocalId")]
        public string ChildOneLocalId { get; set; }
        [Column("childTwoLocalId")]
        public string ChildTwoLocalId { get; set; }
        [Column("childThreeLocalId")]
        public string ChildThreeLocalId { get; set; }
        [Column("childForthLocalId")]
        public string ChildForthLocalId { get; set; }
        [Column("childFifthLocalId")]
        public string ChildFifthLocalId { get; set; }
        [Column("childSixthLocalId")]
        public string ChildSixthLocalId { get; set; }
        public int CategoryId { get; set; }
        public int AddressId { get; set; }
        public int UrgencyId { get; set; }
        public int KnowledgeId { get; set; }




        //other connection tables...
        public virtual Category Category { get; set; }
        public virtual Address Address { get; set; }
        public virtual Urgency Urgency { get; set; }
        public virtual PersonKnowledge Knowledge { get; set; }

    }
}
