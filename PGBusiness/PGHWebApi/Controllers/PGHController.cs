using PGBusiness.Entities;
using PGBusiness.Service;
using PGBusiness.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PGBusiness.WebApi.Controllers
{
    public class PGHController : ApiController
    {
        // GET: api/PGH
        public IEnumerable<PayingGuestHouse> Get()
        {
            IPGFactory factory = new PGFactory();
            IPGBusinessModel model = new PGBusinessModel(factory);

            return model.GetPgs();

            //return new string[] { "value1", "value2" };
        }

        // GET: api/PGH/5
        public string Get(int id)
        {
            return "value"; 
        }

        // POST: api/PGH
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PGH/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PGH/5
        public void Delete(int id)
        {
        }
    }
}
