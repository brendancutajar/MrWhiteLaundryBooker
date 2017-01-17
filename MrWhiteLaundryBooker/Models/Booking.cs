using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrWhiteLaundryBooker.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public DateTime Date { get; set; }

        public bool IsThirdOfDay { get; set; }

        public BookingUser User { get; set; }
    }
}