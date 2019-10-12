using PGBusiness.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.DataAccess
{
    public interface IPGBusinessDataAccess
    {
        List<PayingGuestHouse> GetAllPgs();
        List<PayingGuestHouse> GetPgsByOwnedUser(User pgRegisteredUser);
        List<PayingGuestHouse> GetPgsByArea(Area area);
        List<PayingGuestHouse> GetPgsBySearchFilter(SearchFilterCriteria searchFilter);
        PayingGuestHouse GetPg(Guid pgId);
    }

    public class PGBusinessDataAccess : IPGBusinessDataAccess
    {
        private PGStayBusinessEntities _dbContext;

        public PGBusinessDataAccess()
        {
            _dbContext = PGStayBusiness.DBContext;
            GetAllCodeValues();
        }

        public PayingGuestHouse GetPg(Guid pgId)
        {
            throw new NotImplementedException();
        }

        public List<PayingGuestHouse> GetAllPgs()
        {

            var pgs = (from pg in _dbContext.tbl_pgsb_paying_guest_homestay
                       select new PayingGuestHouse
                       {
                           PGFullName = pg.name,
                           AddressLine1 = pg.address_line_1,
                           AddressLine2 = pg.address_line_2,
                           DetailedDescription = pg.incharge_person_details,
                           IsInCharge = !string.IsNullOrEmpty(pg.incharge_id),
                           OwnerName = pg.owner_name,
                           PhoneNumber = pg.contact_phone_number,
                           Email = pg.email_id,
                           PGMasterId = Guid.Parse(pg.pg_id),
                           //PointOfContact = pg.tbl_pgsb_users.
                           Area = new Area(CodeValues.GetCodeValue("Area", pg.area_code), CodeValues.GetCodeValue("pincode", Convert.ToInt32(pg.pin_code))),
                           PGType = new PGTypeGenderWise(CodeValues.GetCodeValue("pgtype", pg.pg_type_code)),
                           //PointOfContact
                           
                           //pg.tbl_pgsb_pg_amenities.ToList().ForEach(
                           //a =>
                           //{
                           //    Amenities.Add(CodeValues.GetCodeValue("PGAmenity", a.amenity_code));
                           //}),
                       }
                      ) ;

            return pgs.ToList();

        }

        private void GetAllCodeValues()
        {
            if (CodeValues.IsLoaded)
                return;

            var cds = (from cd in _dbContext.tbl_pgsb_code_values
                       select new CodeValue
                       {
                           Code = cd.code,
                           CodeValueDesc = cd.code_value_desc,
                           CodeValueDisplay = cd.code_value,
                           CodeValueType = cd.code_value_type,
                           CodeValueId = cd.code_value_id,
                           ParentCode = cd.tbl_pgsb_code_values2.code,
                           ParentCodeValueType = cd.tbl_pgsb_code_values2.code_value_type,
                       }).ToList();

            CodeValues.SetCodeValues(cds);
        }

        public List<PayingGuestHouse> GetPgsByOwnedUser(User pgRegisteredUser)
        {
            throw new NotImplementedException();
        }

        public List<PayingGuestHouse> GetPgsByArea(Area area)
        {
            throw new NotImplementedException();
        }

        public List<PayingGuestHouse> GetPgsBySearchFilter(SearchFilterCriteria searchFilter)
        {
            throw new NotImplementedException();
        }
    }
}
