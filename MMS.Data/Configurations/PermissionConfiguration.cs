using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class PermissionConfiguration : EntityBaseConfiguration<Permission>
    {
        public  PermissionConfiguration()
        {
            Property(e => e.Name).IsRequired().HasMaxLength(100);
            Property(e => e.Description).IsOptional().HasMaxLength(1000);
        }
    }
}
