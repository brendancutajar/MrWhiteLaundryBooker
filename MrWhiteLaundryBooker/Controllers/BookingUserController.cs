using MrWhiteLaundryBooker.Data;
using MrWhiteLaundryBooker.Models;
using Microsoft.AspNet.Identity;
using System.Web.Http;
using System.Linq;

namespace MrWhiteLaundryBooker.Controllers
{
    [Authorize]
    [RoutePrefix("api/bookingUsers")]
    public class BookingUserController : ApiController
    {
        private readonly BookingUserRepository _userRepository;

        public BookingUserController(BookingUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("")]
        [HttpGet]
        // GET: api/BookingUsers
        public BookingUser Get()
        {
            var userId = User.Identity.GetUserId();
            return _userRepository.Search(u => u.Id == userId).Single();
        }
    }
}
