using Microsoft.AspNet.Identity;
using MrWhiteLaundryBooker.Models;
using MrWhiteLaundryBooker.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MrWhiteLaundryBooker.Controllers
{
    [Authorize]
    [RoutePrefix("api/bookings")]
    public class BoookingController : ApiController
    {
        private readonly IBookingService _bookingService;

        public BoookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [Route("")]
        [HttpGet]
        // GET: api/Boookings
        public IEnumerable<Booking> Get()
        {
            return _bookingService.GetBookings();
        }

        [Route("")]
        [HttpPost]
        // POST: api/Boookings
        public Booking Post([FromBody]Booking booking)
        {
            if (booking != null)
            {
                booking.UserId = User.Identity.GetUserId();
            }
            try
            {
                return _bookingService.Create(booking);
            }
            catch (InvalidOperationException e)
            {
                throw new HttpException((int)HttpStatusCode.Forbidden, e.Message);
            }
        }
    }
}
