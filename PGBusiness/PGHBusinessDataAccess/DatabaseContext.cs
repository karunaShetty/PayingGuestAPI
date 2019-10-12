using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.DataAccess
{
    public sealed class PGStayBusiness
    {
        private static  PGStayBusinessEntities _context = null;
        private static readonly object padlock = new object();
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static PGStayBusiness()
        {
        }

        private PGStayBusiness()
        {
        }

        public static PGStayBusinessEntities DBContext
        {
            get
            {
                lock (padlock)
                {
                    if (_context == null)
                    {
                        _context = new PGStayBusinessEntities();
                    }
                    return _context;
                }
            }
            
        }
    }
}
