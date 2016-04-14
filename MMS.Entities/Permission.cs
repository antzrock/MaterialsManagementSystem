using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public class Permission : IEntityBase
    {
        public Permission()
        {
            IsActive = true;
        }

        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }

        public bool IsActive { get; set; }

        //Permission Fields
        public string Name { get; set; }

        public string Description { get; set; }

        //Relationships
        public ICollection<Role> Roles { get; set; }
    }
}
