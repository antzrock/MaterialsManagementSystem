using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class EmployeeConfiguration : EntityBaseConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            Property(e => e.EmployeeID).IsRequired().HasMaxLength(150);
            Property(e => e.StartDate).IsRequired();
            Property(e => e.HiredDate).IsRequired();
            Property(e => e.EndDate).IsOptional();
            HasRequired(e => e.Profile).WithOptional(e => e.EmployeeDetails);
        }
    }
}
