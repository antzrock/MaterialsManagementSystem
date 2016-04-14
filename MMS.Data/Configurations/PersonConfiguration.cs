using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class PersonConfiguration : EntityBaseConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(e => e.Firstname).IsRequired().HasMaxLength(250);
            Property(e => e.Lastname).IsRequired().HasMaxLength(250);
            Property(e => e.Middlename).IsOptional().HasMaxLength(250);
            Property(e => e.NameExtension).IsOptional().HasMaxLength(25);
            Property(e => e.Title).IsOptional().HasMaxLength(25);
            Property(e => e.Sex).IsRequired();
            Property(e => e.CivilStatus).IsRequired();
            Property(e => e.Nationality).IsRequired();
            HasRequired(e => e.UserDetails).WithOptional(e => e.Profile);
            HasOptional(e => e.EmployeeDetails).WithRequired(e => e.Profile);
        }
    }
}
