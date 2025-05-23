using Microsoft.EntityFrameworkCore;

namespace HotelManagment.Booking
{
    public class BookingsDbContext: DbContext
    {
        public BookingsDbContext(DbContextOptions<BookingsDbContext> choices)
        : base(choices)
        {
        }

        public DbSet<Bookings> Booking { get; set; }
    }
}
