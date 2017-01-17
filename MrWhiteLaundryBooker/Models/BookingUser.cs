using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MrWhiteLaundryBooker.Models
{
    [Table("AspNetUsers")]
    public class BookingUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}