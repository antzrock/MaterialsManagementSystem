using MMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Data.Configurations
{
    public class UserConfiguration : EntityBaseConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.Username).IsRequired().HasMaxLength(100);
            Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            Property(u => u.Salt).IsRequired().HasMaxLength(200);
            Property(u => u.IsLocked).IsRequired();
            Property(u => u.AvatarPicPath).IsOptional().HasMaxLength(1000);
            Property(u => u.ProfilePicPath).IsOptional().HasMaxLength(1000);
            Property(u => u.ProfileQuote).IsOptional().HasMaxLength(2000);
        }
    }
}
