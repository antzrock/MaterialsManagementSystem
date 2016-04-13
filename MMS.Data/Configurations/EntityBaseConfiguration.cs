using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.ID);
            Property(e => e.CreatedDate).IsRequired();
            Property(e => e.CreatedBy).IsRequired();
            Property(e => e.UpdatedBy).IsOptional();
            Property(e => e.UpdatedDate).IsOptional();
            Property(e => e.RowVersion).IsRowVersion();
        }
    }
}
