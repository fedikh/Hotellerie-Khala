using Hotellerie_Khala.Models.HotellerieModel;
using Microsoft.EntityFrameworkCore;

namespace Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Appreciation> Appreciations { get; set; }
    }
}