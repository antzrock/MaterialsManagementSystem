using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS.Entities
{
    public enum Sex
    {
        Male,
        Female
    }

    public enum CivilStatus
    {
        Single,
        Married,
        LegallySeparated,
        Widow,
        Widower
    }

    public class Person : IEntityBase
    {

        public Person()
        {
            PermanentAddress = new Address();
            CurrentAddress = new Address();
            ContactInformation = new ContactInformation();
            GovernmentMandatedInformation = new GovernmentMandatedInformation();
        }

        //IEntityBase Fields
        public int ID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }

        //Person Fields
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Middlename { get; set; }

        public string NameExtension { get; set; }

        public string Nickname { get; set; }
        
        public string Title { get; set; }

        public Sex Sex { get; set; }

        public CivilStatus CivilStatus { get; set; }

        public string Nationality { get; set; }

        public Address PermanentAddress { get; set; }

        public Address CurrentAddress { get; set; }

        public ContactInformation ContactInformation { get; set; }

        public GovernmentMandatedInformation GovernmentMandatedInformation { get; set; }
    }
}
