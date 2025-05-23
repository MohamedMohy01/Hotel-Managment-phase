using Microsoft.EntityFrameworkCore;

namespace HotelManagment.Room
{
    public class RoomsDbContext: DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> actions)
       : base(actions)
        {
        }

        public DbSet<Rooms> Room { get; set; }

    }
}
