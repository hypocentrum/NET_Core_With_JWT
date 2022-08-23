using Microsoft.EntityFrameworkCore;

namespace mHealthBank_Fariz.Entities
{
    public class MyContext : DbContext
    {
        public MyContext() { }
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>().ToTable("UserProfiles");
        }
    }
}
