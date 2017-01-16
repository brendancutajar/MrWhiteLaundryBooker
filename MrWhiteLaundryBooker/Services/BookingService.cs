using MrWhiteLaundryBooker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MrWhiteLaundryBooker.Models;

namespace MrWhiteLaundryBooker.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public Booking Create(Booking booking)
        {
            var bookings = _bookingRepository.Search(
                        b => b.UserId == booking.UserId 
                            && b.Date.Month == booking.Date.Month).ToList();

            if (bookings.Count() < 3)
                return _bookingRepository.Create(booking);
            else
                throw new InvalidOperationException("Cannot add more than 3 bookings per month");

        }

        public IList<Booking> GetBookings()
        {
            throw new NotImplementedException();
        }
    }
}