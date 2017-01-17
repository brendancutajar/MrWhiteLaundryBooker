using MrWhiteLaundryBooker.Models;
using System.Data.Entity;

namespace MrWhiteLaundryBooker.Data
{
    public class LaundryBookerContext : DbContext
    {
        public LaundryBookerContext():base("DefaultConnection")
        {
            
        }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingUser> BookingUsers { get; set; }
    }
}