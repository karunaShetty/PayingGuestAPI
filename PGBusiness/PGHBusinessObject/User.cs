using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Entities
{
    public class User
    {
        public Guid UserMasterId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public UserTypeMaster UserType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Area AreaDetail { set; get; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
    }
}
