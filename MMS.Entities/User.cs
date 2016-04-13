using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public class User : IEntityBase
    {

        public User()
        {
            IsLocked = false;
        }

        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }

        //User Fields
        public string Username { get; set; }
        
        public string AvatarPicPath { get; set; }

        public string ProfilePicPath { get; set; }

        public string ProfileQuote { get; set; }

        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }

    }
}
