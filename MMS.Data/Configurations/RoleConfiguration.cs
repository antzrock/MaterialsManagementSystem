using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class RoleConfiguration : EntityBaseConfiguration<Role>
    {
        public RoleConfiguration()
        {
            Property(e => e.Name).IsRequired().HasMaxLength(100);
            HasMany(e => e.Users).WithMany(e => e.Roles);
            HasMany(e => e.Permissions).WithMany(e => e.Roles).Map(e => { e.MapLeftKey("Permission_ID"); e.MapRightKey("Role_ID"); e.ToTable("RolePermissions");});
        }
    }
}
