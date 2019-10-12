using PGBusiness.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Service
{
    public interface IPGFactory
    {
        IPGBusinessDataAccess GetPGBusinessDataAccess();
    }
    public class PGFactory : IPGFactory
    {
        public IPGBusinessDataAccess GetPGBusinessDataAccess()
        {
            return new PGBusinessDataAccess();
        }
    }
}
