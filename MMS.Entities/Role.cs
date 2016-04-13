using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public class Role : IEntityBase
    {
        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }

        //Role Fields
        public string Name { get; set; }
    }
}
