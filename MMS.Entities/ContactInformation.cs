using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public class ContactInformation
    {
        //Multiple (Area Code + Telephone No) delimited by / 
        public string LandlineNumber { get; set; }

        //Multiple delimited by /
        public string MobileNumber { get; set; }

        //Multiple delimited by /
        public string EmailAddress { get; set; }
    }
}
