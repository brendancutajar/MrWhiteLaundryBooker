using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrWhiteLaundryBooker.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime Date { get; set; }

        public bool IsThirdOfDay { get; set; }
    }
}