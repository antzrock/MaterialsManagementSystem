using MMS.Data.Configurations;
using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data
{
    public class MMSContext : DbContext
    {
        public MMSContext()
            : base("dbconnection")
        {
            Database.SetInitializer<MMSContext>(null);
        }

        #region Entity Sets
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Permission> Permissions { get; set; }
        public IDbSet<Person> Persons { get; set; }


        #endregion

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Add configurations here...
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new PermissionConfiguration());

            //Complex types used by Person
            modelBuilder.ComplexType<Address>();
            modelBuilder.ComplexType<ContactInformation>();
            modelBuilder.ComplexType<GovernmentMandatedInformation>();

            modelBuilder.Configurations.Add(new PersonConfiguration());    
                

        }
    }
}
