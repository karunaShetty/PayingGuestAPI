using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Entities
{
    public class SearchFilterCriteria
    {
        public List<Area> Locations { get; set; }
        public PGTypeGenderWise PGTypeGender { get; set; }
        public List<PGSharingClassification> PGSharing { get; set; }
        public PGAmenities Amenities { get; set; }
    }
}
