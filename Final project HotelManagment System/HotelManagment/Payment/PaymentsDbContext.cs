using HotelManagment.Booking;
using Microsoft.EntityFrameworkCore;

namespace HotelManagment.Payment
{
    public class PaymentsDbContext: DbContext
    {

        public PaymentsDbContext(DbContextOptions<PaymentsDbContext> pickups)
            : base(pickups)  
        {
            
        }

        public DbSet<Payments> Payment { get; set; }
    }
}
