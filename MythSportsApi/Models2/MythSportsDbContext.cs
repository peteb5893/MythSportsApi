using Microsoft.EntityFrameworkCore;

namespace MythSportsApi.Models2
{
    public partial class MythSportsDbContext : DbContext
    {
        public MythSportsDbContext(DbContextOptions<MythSportsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SportsEvent> SportsEvent { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportsEvent>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
