using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Entities
{
    public class PayingGuestHouse
    {
        public PayingGuestHouse()
        {
            PointOfContact = new User();
            Area = new Area(new CodeValue(),new CodeValue());
            PGType = new PGTypeGenderWise(new CodeValue());
            PGSharing = new List<PGSharingClassification>();
            Amenities = new List<PGAmenities>();
            Images = new List<string>();
        }

        public Guid PGMasterId { get; set; }
        public string PGFullName { get; set; }
        public string DetailedDescription { get; set; }
        public string OwnerName { get; set; }
        public User PointOfContact { get; set; }
        public bool IsInCharge { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Area Area { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public PGTypeGenderWise PGType { get; set; }
        public List<PGSharingClassification> PGSharing { get; set; }
        public List<PGAmenities> Amenities { get; set; }
        public List<string> Images { get; set; }
    }
}
