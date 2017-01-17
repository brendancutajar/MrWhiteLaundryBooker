using MrWhiteLaundryBooker.Models;

namespace MrWhiteLaundryBooker.Data
{
    public class BookingRepository : BaseRepository<Booking>
    {
        private readonly LaundryBookerContext _context;

        public BookingRepository(LaundryBookerContext context):base(context)
        {
            _context = context;
        }

        public Booking Create(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();

            return booking;
        }
    }
}