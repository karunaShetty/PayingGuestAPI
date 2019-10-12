using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Entities
{
    public class CodeValue
    {
        public int Code { get; set; }
        public string CodeValueType { get; set; }
        public string CodeValueDisplay { get; set; }
        public string CodeValueDesc { get; set; }
        public decimal CodeValueId { get; set; }
        public int ParentCode { get; set; }
        public string ParentCodeValueType { get; set; }
    }

    public class UserTypeMaster
    {
        public int Code { get; set; }
        public string UserType { get; set; }

    }

    public class Area
    {
        public Area(CodeValue areaCodeValue, CodeValue pinCodeValue)
        {
            Code = areaCodeValue.Code;
            Name = areaCodeValue.CodeValueDisplay;
            Pincode = pinCodeValue.CodeValueDisplay;
            City = new City(CodeValues.GetCodeValue("City", areaCodeValue.ParentCode));
        }
        
        public int Code { get; set; }
        public string Pincode { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
    }
    public class State
    {
        public State(CodeValue stateCodeValue)
        {
            Code = stateCodeValue.Code;
            Name = stateCodeValue.CodeValueDisplay;
            Country = new Country(CodeValues.GetCodeValue("country", stateCodeValue.ParentCode));
        }
        public int Code { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public  Country(CodeValue countryCodeValue)
        {
            Code = countryCodeValue.Code;
            Name = countryCodeValue.CodeValueDisplay;
        }
        public int Code { get; set; }
        public string Name { get; set; }
    }
    public class City
    {
        public City(CodeValue cityCodeValue)
        {
            Code = cityCodeValue.Code;
            Name = cityCodeValue.CodeValueDisplay;

            State = new State(CodeValues.GetCodeValue("State", cityCodeValue.ParentCode));
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }

    //MALE,
    //FEMALE,
    //    TRANSGENDER,
    //    UNKNOWN
    public class GenderType
    {
        public int Code { get; set; }
        public string Gender { get; set; }
    }

    /*
      GENTSPG,
        LADIESPG,
        MIXED,
        OTHERS*/
    public class PGTypeGenderWise
    {
        public PGTypeGenderWise(CodeValue pgTypeCodeValue)
        {
            Code = pgTypeCodeValue.Code;
            PGType = pgTypeCodeValue.CodeValueDisplay;
        }
        public int Code { get; set; }
        public string PGType { get; set; }
    }


    public class PGSharingClassification
    {
        public PGSharingClassification(CodeValue pgSharingCodeValue)
        {
            Code = pgSharingCodeValue.Code;
            PGSharingType = pgSharingCodeValue.CodeValueDisplay;
        }
   
        public int Code { get; set; }
        public string PGSharingType { get; set; }
    }

    //PGAmenities Master Table
    public class PGAmenities
    {
        public PGAmenities(CodeValue pgCodeValue)
        {
            Code = pgCodeValue.Code;
            PGAmenitiesType = pgCodeValue.CodeValueDisplay;
            Description = pgCodeValue.CodeValueDesc;
        }
        public int Code { get; set; }
        public string PGAmenitiesType { get; set; }
        public string Description { get; set; }

    }
}
