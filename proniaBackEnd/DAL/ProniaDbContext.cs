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
    }
}
