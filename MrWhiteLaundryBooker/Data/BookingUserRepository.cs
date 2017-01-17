using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MrWhiteLaundryBooker.Models;
using System.Linq.Expressions;

namespace MrWhiteLaundryBooker.Data
{
    public class BookingUserRepository : BaseRepository<BookingUser>
    {
        private readonly LaundryBookerContext _context;

        public BookingUserRepository(LaundryBookerContext context) : base(context)
        {
            _context = context;
        }
    }
}