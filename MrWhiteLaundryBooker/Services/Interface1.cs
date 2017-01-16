using MrWhiteLaundryBooker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrWhiteLaundryBooker.Services
{
    public interface IBookingService
    {
        IList<Booking> GetBookings();

        Booking Create(Booking booking);
    }
}
