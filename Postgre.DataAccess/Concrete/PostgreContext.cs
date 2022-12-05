using Postgre.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Postgre.DataAccess.Concrete
{
    public class PostgreContext : DbContext
    {
        public PostgreContext() : base(nameOrConnectionString:"PostgreConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
