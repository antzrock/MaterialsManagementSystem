using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public interface IEntityBase
    {
        int ID { get; set; }

        int CreatedBy { get; set; }

        DateTime CreatedDate { get; set; }

        int? UpdatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        byte[] RowVersion { get; set; }

        bool IsActive { get; set; }
    }
}
