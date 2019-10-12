using PGBusiness.Entities;
using PGBusiness.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Service.Models
{
    public interface IPGBusinessModel
    {
        List<PayingGuestHouse> GetPgs();
        PayingGuestHouse GetPg(string pgId);
    }

    public class PGBusinessModel: IPGBusinessModel
    {
        private IPGFactory _factory;
        private IPGBusinessDataAccess _pgDataAccess;
        public PGBusinessModel(IPGFactory factory)
        {
            _factory = factory;

            _pgDataAccess = _factory.GetPGBusinessDataAccess();
        }

        public PayingGuestHouse GetPg(string pgId)
        {
            throw new NotImplementedException();
        }

        public List<PayingGuestHouse> GetPgs()
        {
            var payingGuestHouses = _pgDataAccess.GetAllPgs();

            return payingGuestHouses;
        }
    }
}
