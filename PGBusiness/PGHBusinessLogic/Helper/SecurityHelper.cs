using System;
using System.Collections.Generic;
using System.Text;

namespace PGBusiness.Service.Helpers
{
    public sealed class SecurityHelper
    {
        private static volatile SecurityHelper _instance;
        private static object syncRoot = new Object();

        /// <summary>
        /// You will never create an instance of this object.  Instead its instances will be managed internally.
        /// Call the static function Instance instead.
        /// </summary>
        private SecurityHelper() { }

        /// <summary>
        /// Returns the one and only instance for this object.  Use this property to get an instance of the object to use.
        /// You will never create an instance of this object.
        /// </summary>
        public static SecurityHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new SecurityHelper();
                        }
                    }
                }

                return _instance;
            }
        }

        public static int VIEW_PERM = 1;
        public static int ADD_PERM = 2;
        public static int MOD_PERM = 4;
        public static int DEL_PERM = 8;
        public static int PRINT_PERM = 16;


        private const short MAX_LOGIN_ID = 20;
        private const short MAX_PSWD_ID = 40;
        private const short MAX_USER_ID = 10;
        private const short MAX_PIN_ID = 40;
        private const short MAX_GROUP_ID = 4;
        private const short MAX_PRODUCT_ID = 10;
        private const short MAX_ENTERPRISE_ID = 5;
        private const short MAX_ENTREPRISE_NAME = 40;
    }
}
