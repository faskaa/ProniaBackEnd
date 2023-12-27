using Microsoft.EntityFrameworkCore;
using proniaBackEnd.Entities;

namespace proniaBackEnd.DAL
{
    public class ProniaDbContext : DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlantCategory> PlantCategories { get; set; }
    }
}
