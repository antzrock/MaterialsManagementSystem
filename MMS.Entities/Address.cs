using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public class Address
    {
        
        //Unit/Room No./Floor
        public string UnitNumber { get; set; }
                
        public string BuildingName { get; set; }

        //Lot/Block/House/Building. No
        public string BuildingNumber { get; set; }

        public string Street { get; set; }

        //Subdivision/Village
        public string Subdivision { get; set; }

        public string Barangay { get; set; }

        public string Municipality { get; set; }

        public string City { get; set; }

        public bool IsCity { get; set; }

        public string Province { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }
        
        public int ZipCode { get; set; }
    }
}
