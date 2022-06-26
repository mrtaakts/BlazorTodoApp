using Microsoft.EntityFrameworkCore;

namespace TodoApp.Data.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
        public DbSet<TaskModel> Tasks { get; set; }



    }
}
