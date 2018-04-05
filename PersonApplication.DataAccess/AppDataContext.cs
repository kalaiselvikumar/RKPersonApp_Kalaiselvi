using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication.DataAccess
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("name=PersonAppConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Address> Address { get; set; }
    }
}
