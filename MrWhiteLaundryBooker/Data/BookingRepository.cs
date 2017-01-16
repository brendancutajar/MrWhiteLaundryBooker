using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MrWhiteLaundryBooker.Models;
using System.Linq.Expressions;

namespace MrWhiteLaundryBooker.Data
{
    public class BookingRepository : IBookingRepository
    {
        private readonly LaundryBookerContext _context;

        public BookingRepository(LaundryBookerContext context)
        {
            _context = context;
        }

        public Booking Create(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return booking;
        }

        public IQueryable<Booking> Search(params Expression<Func<Booking, bool>>[] predicates)
        {
            var query = _context.Bookings.AsQueryable<Booking>();

            foreach(var predicate in predicates)
            {
                query = query.Where<Booking>(predicate);
            }

            return query;
        }
    }
}