using MrWhiteLaundryBooker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MrWhiteLaundryBooker.Models;
using System.Data.Entity;

namespace MrWhiteLaundryBooker.Services
{
    public class BookingService 
    {
        private readonly BookingRepository _bookingRepository;

        public BookingService(BookingRepository bookingRepository)
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
            var bookings = _bookingRepository.Search().Include(booking=>booking.User).ToList();

            return bookings;
        }
    }
}