using MrWhiteLaundryBooker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MrWhiteLaundryBooker.Data
{
    public interface IBookingRepository
    {
        IQueryable<Booking> Search(params Expression<Func<Booking, bool>>[] predicates);

        Booking Create(Booking booking);
    }
}
