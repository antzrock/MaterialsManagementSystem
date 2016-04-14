namespace MMS.Data.Migrations
{
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MMS.Data.MMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MMS.Data.MMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            DateTime dateToday = DateTime.Now;

            context.Roles.AddOrUpdate(
                r => r.Name,
                new Role { Name = "Admin", CreatedBy = 1, CreatedDate = dateToday, IsActive = true }
                );

            context.Permissions.AddOrUpdate(
                p => p.Name,
                new Permission { Name = "ADD_USER", Description = "Can add user.", CreatedBy = 1, CreatedDate = dateToday, IsActive = true }
                );

            //Assign permissions to Admin Role....
            Role AdminRole = context.Roles.Where(r => r.Name == "Admin").Include(r => r.Permissions).FirstOrDefault();

            if (AdminRole != null)
            {
                Permission AddUserPermission = context.Permissions.Where(p => p.Name == "ADD_USER").FirstOrDefault();

                if (AddUserPermission != null)
                {
                    
                    if (AdminRole.Permissions == null)
                    {
                        AdminRole.Permissions = new List<Permission>();
                    }

                    AdminRole.Permissions.Add(AddUserPermission);
                    context.SaveChanges();
                }
            }

        }
    }
}
