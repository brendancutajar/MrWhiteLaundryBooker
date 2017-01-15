using MrWhiteLaundryBooker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MrWhiteLaundryBooker.Controllers
{
    [Authorize]
    [RoutePrefix("bookings")]
    public class BoookingController : ApiController
    {
        [Route("")]
        [HttpGet]
        [AllowAnonymous]
        // GET: api/Boookings
        public IEnumerable<Booking> Get()
        {
            throw new NotImplementedException();
        }

        [Route("")]
        [HttpGet]
        // GET: api/Boooking/5
        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        [Route("")]
        [HttpPost]
        // POST: api/Boooking
        public void Post([FromBody]Booking value)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Boooking/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Boooking/5
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
